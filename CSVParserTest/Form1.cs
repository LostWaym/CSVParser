using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVParserTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_parse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_input.Text))
            {
                MessageBox.Show("请输入待解析文本！");
                return;
            }

            try
            {
                CSVParser.Lexer lexer = new CSVParser.Lexer();
                lexer.Load(m_input.Text);
                CSVParser.Parser parser = new CSVParser.Parser(lexer);
                CSVParser.CSVTable table = parser.GetTable();
                m_output.Text = $"总共{table.rows}行，{table.columns}列{Environment.NewLine}{table}";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
