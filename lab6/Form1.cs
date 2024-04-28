using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form, Form1I
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void showFlights(FlightForView[] flv)
        {
            ticketArea.Visible = false;
            dataGridView1.Visible = true;

            fromInput.Visible = true;
            toInput.Visible = true;
            selectButton.Visible = true;

            buyInput.Visible = false;
            buyButton.Visible = false;


            for (int i=dataGridView1.RowCount-1; i>=0; i--)
            {
                dataGridView1.Rows.RemoveAt(i);
            }

            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "Откуда";
            this.dataGridView1.Columns[1].Name = "Куда";
            this.dataGridView1.Columns[2].Name = "Время перелёта(мин.)";
            this.dataGridView1.Columns[3].Name = "Время вылета";
            this.dataGridView1.Columns[3].Width = 150;

            for (int i=0; i<flv.Length; i++)
            {
                string[] row = { flv[i].from, flv[i].to, flv[i].durationMinutes.ToString(), flv[i].startTime.ToString() };
                this.dataGridView1.Rows.Add(row);
            }
        }

        public void showPlaces(PlaceForView[] plv)
        {
            fromInput.Visible = false;
            toInput.Visible = false;
            selectButton.Visible = false;

            buyInput.Visible = true;
            buyButton.Visible = true;


            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                dataGridView1.Rows.RemoveAt(i);
            }

            this.dataGridView1.ColumnCount = 2;
            this.dataGridView1.Columns[0].Name = "Место";
            this.dataGridView1.Columns[1].Name = "Цена";

            for (int i = 0; i < plv.Length; i++)
            {
                string[] row = { plv[i].placeNumber.ToString(), plv[i].price.ToString() };
                this.dataGridView1.Rows.Add(row);
            }
        }

        public void showTicket(Ticket t)
        {
            fromInput.Visible = false;
            toInput.Visible = false;
            selectButton.Visible = false;

            buyInput.Visible = false;
            buyButton.Visible = false;

            dataGridView1.Visible = false;

            ticketArea.Visible = true;

            ticketArea.Text = "   Ваш билет!   " + "\n" +
                            "Рейс: " + t.from + "-" + t.to + "\n" +
                            "Время вылета: " + t.startTime.ToString() + "\n" +
                            "Время перелёта: " + t.durationMinutes.ToString() + "\n" +
                            "Место: " + t.placeNumber.ToString() + "\n" +
                            "Цена: " + t.price.ToString();
        }

        public string getFromInput()
        {
            return this.fromInput.Text;
        }

        public string getToInput()
        {
            return this.toInput.Text;
        }

        public string getBuyInput()
        {
            return this.buyInput.Text;
        }

        public void addSelectAllListener(EventHandler handler)
        {
            this.selectAll.Click += handler;
        }

        public void addSelectButton(EventHandler handler)
        {
            this.selectButton.Click += handler;
        }

        public void addBuyListener(EventHandler handler)
        {
            this.buyButton.Click += handler;
        }

        public void addGridCellClickListener(DataGridViewCellEventHandler handler)
        {
            this.dataGridView1.CellDoubleClick += handler;
        }

    }
}
