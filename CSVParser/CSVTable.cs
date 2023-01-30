using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class CSVTable
    {
        public List<List<string>> m_table;

        public int rows, columns;

        internal void SetTable(List<List<string>> table)
        {
            m_table = table;
            rows = table.Count;
            columns = 0;
            foreach (var item in table)
            {
                columns = item.Count > columns ? item.Count : columns;
            }
        }

        public string Get(int row, int column)
        {
            List<string> list = GetRow(row);
            if (list == null)
                return null;

            return list.Count > column ? list[column] : null;
        }

        public List<string> GetRow(int row)
        {
            return m_table.Count > row ? m_table[row] : null;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in m_table)
            {
                foreach (var item2 in item)
                {
                    builder.Append($"{item2}\t");
                }
                if (item.Count > 0)
                {
                    builder.Remove(builder.Length - 1, 1);
                }
                builder.Append(Environment.NewLine);
            }

            if (m_table.Count > 0)
            {
                builder.Remove(builder.Length - Environment.NewLine.Length, Environment.NewLine.Length);
            }

            return builder.ToString();
        }
    }
}
