using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class ValuteCursTable : ValuteCursTableI
    {
        private ValuteCurs[] VCTable;

        public ValuteCursTable(DataSet ds)
        {
            DataTable dataTable = ds.Tables[0];

            int n = dataTable.Rows.Count;
            VCTable = new ValuteCurs[n];

            for(int i=0; i<n; i++)
            {
                VCTable[i] = new ValuteCurs();

                VCTable[i].Vname = dataTable.Rows[i][0].ToString();
                VCTable[i].Vnom = decimal.Parse(dataTable.Rows[i][1].ToString());
                VCTable[i].Vcurs = decimal.Parse(dataTable.Rows[i][2].ToString());
                VCTable[i].Vcode = int.Parse(dataTable.Rows[i][3].ToString());
                VCTable[i].VchCode = dataTable.Rows[i][4].ToString();
                VCTable[i].VunitRate = double.Parse(dataTable.Rows[i][5].ToString());
            }
        }

        public ValuteCurs getValuteCurs(int i)
        {
            return VCTable[i];
        }

        public int getSize()
        {
            return VCTable.Length;
        }
    }
}
