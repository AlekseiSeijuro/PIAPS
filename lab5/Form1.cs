using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace lab5
{
    public partial class Form1 : Form
    {


        BankViewI view;
        ValuteCursTableI VCTable;
        ValuteCursDynamicTableI VCDTable;
        VcodeTableI VTable;

        public Form1()
        {
            view = new BankView(this.Controls);
            view.addCursesButtonListener(cursesHandler);
            view.addCursesDynamicButtonListener(cursesDynamicHandler);

            MyBankService.DailyInfoSoapClient service = new MyBankService.DailyInfoSoapClient();

            DataSet ds = service.GetCursOnDate(System.DateTime.Now);
            VCTable = new ValuteCursTable(ds);
            view.showValuteCurses(VCTable);

            InitializeComponent();
        }

        public void cursesHandler(object sender, EventArgs e)
        {
            MyBankService.DailyInfoSoapClient service=new MyBankService.DailyInfoSoapClient();
            
            DataSet ds=service.GetCursOnDate(System.DateTime.Now);
            VCTable= new ValuteCursTable(ds);
            view.showValuteCurses(VCTable);
        }

        public void cursesDynamicHandler(object sender, EventArgs e)
        {
            MyBankService.DailyInfoSoapClient service = new MyBankService.DailyInfoSoapClient();
            //справочник валют
            DataSet ds = service.EnumValutes(false);
            VTable = new VcodeTable(ds);

            //внутренний код валюты
            string Vcode = VTable.getVcodeByChCode(view.getValuteInput());

            //динамика валют
            ds = service.GetCursDynamic(DateTime.Now.AddDays(-30), DateTime.Now, Vcode);
            VCDTable = new ValuteCursDynamicTable(ds);
            view.showDynamicValuteCurses(VCDTable);
        }
    }
}
