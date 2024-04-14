using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class ValuteCursDynamicTable : ValuteCursDynamicTableI
    {
        ValuteCursDynamic[] VCDTable;

        public ValuteCursDynamicTable(DataSet ds)
        {
            DataTable dataTable = ds.Tables[0];

            int n = dataTable.Rows.Count;
            VCDTable = new ValuteCursDynamic[n];

            for (int i = 0; i < n; i++)
            {
                VCDTable[i] = new ValuteCursDynamic();

                VCDTable[i].CursDate = DateTime.Parse(dataTable.Rows[i][0].ToString());
                VCDTable[i].Vcode = dataTable.Rows[i][1].ToString();
                VCDTable[i].Vnom = decimal.Parse(dataTable.Rows[i][2].ToString());
                VCDTable[i].Vcurs = decimal.Parse(dataTable.Rows[i][3].ToString());
                VCDTable[i].VunitRate = double.Parse(dataTable.Rows[i][4].ToString());
            }
        }

        public ValuteCursDynamic getValuteCursDynamic(int i)
        {
            return VCDTable[i];
        }

        public int getSize()
        {
            return VCDTable.Length;
        }
    }
}
