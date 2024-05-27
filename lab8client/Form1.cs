using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCom;

namespace lab8client
{
    public partial class Form1 : Form, FormI
    {
        public Form1()
        {
            InitializeComponent();
        }


        public double getHtgInput()
        {
            return Double.Parse(htgInput.Text);
        }
        public int getPowOf2Input()
        {
            return int.Parse(powOf2Input.Text);
        }
        public Point[] getPointsInput()
        {
            Point[] points = new Point[3];
            points[0].X = int.Parse(AXInput.Text);
            points[0].Y = int.Parse(AYInput.Text);
            points[1].X = int.Parse(BXInput.Text);
            points[1].Y = int.Parse(BYInput.Text);
            points[2].X = int.Parse(CXInput.Text);
            points[2].Y = int.Parse(CYInput.Text);

            return points;
        }

        public void showHtg(string htg)
        {
            htgOutput.Text = htg;
        }
        public void showPowOf2(string powOf2)
        {
            powOf2Output.Text = powOf2;
        }
        public void showBiggestSide(string biggestSide)
        {
            biggestSideOutput.Text = biggestSide;
        }

        public void addHtgButtonListener(EventHandler handler)
        {
            htgButton.Click += handler;
        }
        public void addPowOf2ButtonListener(EventHandler handler)
        {
            powOf2Button.Click += handler;
        }
        public void addBiggestSideButtonListener(EventHandler handler)
        {
            biggestSideButton.Click += handler;
        }
    }
}
