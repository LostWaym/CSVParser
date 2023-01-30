using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class Lexer
    {
        public string m_content;
        public int m_index;
        public char m_curChar;
        public int m_length;

        public void Load(string content)
        {
            m_content = content;
            m_length = m_content.Length;
        }

        public void Ready()
        {
            m_index = 0;
            m_curChar = '\0';
        }

        public LexerToken GetToken(int offset = 0)
        {
            int realIndex = m_index + offset;
            if (realIndex >= m_length)
                return LexerToken.End;

            m_curChar = m_content[realIndex];
            switch (m_curChar)
            {
                case '"':
                    return LexerToken.Quotation;
                case ',':
                    return LexerToken.Comma;
                case '\t':
                    return LexerToken.Tab;
                case '\r':
                case '\n':
                    return LexerToken.BreakLine;
                default:
                    return LexerToken.Literal;
            }
        }

        public char GetChar(int offset = 0)
        {
            int realIndex = m_index + offset;
            return realIndex >= m_length ? '\0' : m_content[realIndex];
        }

        public void Next(int offset = 1)
        {
            m_index += offset;
        }

        public void JumpSpace(bool includingBreakLine = false)
        {
            if (includingBreakLine)
            {
                LexerToken token;
                while ((token = GetToken()) == LexerToken.Space || token == LexerToken.BreakLine)
                {
                    Next();
                }
            }
            else
            {
                while (GetToken() == LexerToken.Space)
                {
                    Next();
                }
            }
        }

        public void JumpBreakLine()
        {
            LexerToken token = GetToken();
            if (token == LexerToken.BreakLine)
            {
                if (m_curChar == '\r' && GetChar(1) == '\n')
                {
                    Next(2);
                }else
                {
                    Next();
                }
            }
        }
    }
}
