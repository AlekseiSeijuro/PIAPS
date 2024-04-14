using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab5
{
    class BankView : BankViewI
    {
        private DataGridView cursesTable;
        private Button cursesButton, cursesDynamicButton;
        private TextBox valuteInput;
        private Label valuteLabel;
        private Control.ControlCollection controls;

        public BankView(Control.ControlCollection controls)
        {
            this.controls = controls;

            //cursesButton
            cursesButton = new Button();
            controls.Add(cursesButton);

            cursesButton.Location = new System.Drawing.Point(1000, 300);
            cursesButton.Text = "Курсы валют";
            cursesButton.Size = new System.Drawing.Size(200, 75);

            //cursesDynamicButton
            cursesDynamicButton=new Button();
            controls.Add(cursesDynamicButton);

            cursesDynamicButton.Location = new System.Drawing.Point(1000, 450);
            cursesDynamicButton.Text = "В динамике";
            cursesDynamicButton.Size = new System.Drawing.Size(200, 75);

            //valuteInput
            valuteInput= new TextBox();
            controls.Add(valuteInput);

            valuteInput.Location = new System.Drawing.Point(1000, 425);

            //valuteLabel
            valuteLabel = new Label();
            controls.Add(valuteLabel);

            valuteLabel.Text = "Символьный код валюты для просмотра в динамике: ";
            valuteLabel.Width = 300;
            valuteLabel.Location = new System.Drawing.Point(1000, 400);
        }

        public void addCursesButtonListener(EventHandler handler)
        {
            cursesButton.Click += handler;
        }

        public void addCursesDynamicButtonListener(EventHandler handler)
        {
           cursesDynamicButton.Click += handler;
        }

        public string getValuteInput()
        {
            return valuteInput.Text;
        }

        public void showValuteCurses(ValuteCursTableI VCTable)
        {
            controls.Remove(cursesTable);
            cursesTable = new DataGridView();
            controls.Add(cursesTable);

            cursesTable.Location = new System.Drawing.Point(25, 100);
            cursesTable.Size = new System.Drawing.Size(900, 500);

            cursesTable.ColumnCount = 6;

            cursesTable.Columns[0].Name = "Название валюты";
            cursesTable.Columns[0].ReadOnly = true;
            cursesTable.Columns[0].Width = 150;
            cursesTable.Columns[1].Name = "Номинал";
            cursesTable.Columns[1].ReadOnly = true;
            cursesTable.Columns[2].Name = "Курс";
            cursesTable.Columns[2].ReadOnly = true;
            cursesTable.Columns[3].Name = "ISO Цифровой код валюты";
            cursesTable.Columns[3].ReadOnly = true;
            cursesTable.Columns[3].Width = 150;
            cursesTable.Columns[4].Name = "ISO Символьный код валюты";
            cursesTable.Columns[4].ReadOnly = true;
            cursesTable.Columns[4].Width = 150;
            cursesTable.Columns[5].Name = "Курс за 1 единицу валюты";
            cursesTable.Columns[5].ReadOnly = true;
            cursesTable.Columns[5].Width = 150; ;
            for(int i=0; i< VCTable.getSize(); i++)
            {
                ValuteCurs valuteCurs = VCTable.getValuteCurs(i);
                string[] row = { valuteCurs.Vname, valuteCurs.Vnom.ToString(), valuteCurs.Vcurs.ToString(), valuteCurs.Vcode.ToString(), valuteCurs.VchCode, valuteCurs.VunitRate.ToString() };
                cursesTable.Rows.Add(row);
            }
        }

        public void showDynamicValuteCurses(ValuteCursDynamicTableI VCDTable)
        {
            
            controls.Remove(cursesTable);
            
            cursesTable = new DataGridView();
            controls.Add(cursesTable);

            cursesTable.Location = new System.Drawing.Point(25, 100);
            cursesTable.Size = new System.Drawing.Size(900, 500);

            cursesTable.ColumnCount = 5;

            cursesTable.Columns[0].Name = "Дата котирования";
            cursesTable.Columns[0].ReadOnly = true;
            cursesTable.Columns[0].Width = 150;
            cursesTable.Columns[1].Name = "Внутренний код валюты";
            cursesTable.Columns[1].ReadOnly = true;
            cursesTable.Columns[2].Name = "Номинал";
            cursesTable.Columns[2].ReadOnly = true;
            cursesTable.Columns[3].Name = "Курс";
            cursesTable.Columns[3].ReadOnly = true;
            cursesTable.Columns[3].Width = 150;
            cursesTable.Columns[4].Name = "Курс за 1 единицу валюты";
            cursesTable.Columns[4].ReadOnly = true;
            cursesTable.Columns[4].Width = 150;

            for (int i = 0; i < VCDTable.getSize(); i++)
            {
                ValuteCursDynamic valuteCursDynamic = VCDTable.getValuteCursDynamic(i);
                string[] row = { valuteCursDynamic.CursDate.ToString(), valuteCursDynamic.Vcode, valuteCursDynamic.Vnom.ToString(), valuteCursDynamic.Vcurs.ToString(), valuteCursDynamic.VunitRate.ToString() };
                cursesTable.Rows.Add(row);
            }

        }
    }
}
