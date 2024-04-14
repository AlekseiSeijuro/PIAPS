using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class VcodeTable : VcodeTableI
    {
        private Vcode[] VTable;


        public VcodeTable(DataSet ds)
        {
            DataTable dataTable = ds.Tables[0];

            int n = dataTable.Rows.Count;
            VTable = new Vcode[n];

            for (int i = 0; i < n; i++)
            {
                VTable[i] = new Vcode();

                VTable[i].VCode = dataTable.Rows[i][0].ToString();
                VTable[i].VcharCode = dataTable.Rows[i][6].ToString();
            }
        }
        public string getVcodeByChCode(string chCode)
        {
            for(int i = 0; i < VTable.Length; i++)
            {
                if (VTable[i].VcharCode == chCode) return VTable[i].VCode;
            }
            return "";
        }
    }
}
