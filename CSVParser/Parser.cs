using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class Parser
    {
        public Lexer m_lexer;
        public CSVTable m_table;
        public StringBuilder m_builder;
        public Parser(Lexer lexer)
        {
            m_lexer = lexer;
        }

        public CSVTable GetTable()
        {
            if (m_table == null)
            {
                m_table = new CSVTable();
                m_lexer.Ready();

                List<List<string>> table = new List<List<string>>();
                List<string> row = new List<string>();
                table.Add(row);
                m_builder = new StringBuilder();
                LexerToken token;
                while ((token = m_lexer.GetToken()) != LexerToken.End)
                {
                    if (token == LexerToken.Comma)//遇到逗号则保存当前项数据，解析下一项
                    {
                        row.Add(m_builder.ToString());
                        m_builder.Clear();
                        m_lexer.Next();
                    }
                    else if (token == LexerToken.Quotation)//遇到引号转义或开启读取模式
                    {
                        bool readingContent = false;
                        if (m_lexer.GetToken(1) == LexerToken.Quotation)//需转义
                        {
                            if (m_lexer.GetToken(2) == LexerToken.Quotation)//需转义且开启读取模式
                            {
                                readingContent = true;
                                m_lexer.Next(3);
                            }
                            else
                            {
                                m_lexer.Next(2);
                            }
                            m_builder.Append('"');
                        }
                        else//单引号需要开启读取模式
                        {
                            m_lexer.Next();
                            readingContent = true;
                        }

                        if (readingContent)
                        {
                            while ((token = m_lexer.GetToken()) != LexerToken.End)
                            {
                                if (token == LexerToken.Quotation)
                                {
                                    if (m_lexer.GetToken(1) == LexerToken.Quotation)//两个引号连着要转义
                                    {
                                        m_builder.Append('"');
                                        m_lexer.Next(2);
                                    }
                                    else//单个引号为结束
                                    {
                                        m_lexer.Next();
                                        readingContent = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    m_builder.Append(m_lexer.GetChar());
                                    m_lexer.Next();
                                }
                            }

                            if (readingContent)
                            {
                                //missing other quotation
                            }
                        }
                    }
                    else if (token == LexerToken.BreakLine)//遇到换行符结束当前项，保存当前行，解析下一行
                    {
                        row.Add(m_builder.ToString());
                        m_builder.Clear();
                        row = new List<string>();
                        table.Add(row);
                        m_lexer.JumpBreakLine();
                    }
                    else//其他内容进content
                    {
                        m_builder.Append(m_lexer.GetChar());
                        m_lexer.Next();
                    }
                }

                row.Add(m_builder.ToString());//最后一项数据
                m_table.SetTable(table);
            }

            return m_table;
        }
    }
}
