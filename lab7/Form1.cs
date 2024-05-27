using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form, Form1I
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string getDisciplineName()
        {
            return discipName.Text;
        }
        public string getLabNum()
        {
            return labNum.Text;
        }
        public string getLabName()
        {
            return labName.Text;
        }
        public string getGroupName()
        {
            return groupName.Text;
        }
        public string getYourFio()
        {
            return yourFio.Text;
        }
        public string getTeacherFio()
        {
            return teacherFio.Text;
        }
        public void addCreateButtonListener(EventHandler handler)
        {
            createButton.Click += handler;
        }

        public void showMessage(string text, string name)
        {
            MessageBox.Show(text, name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
