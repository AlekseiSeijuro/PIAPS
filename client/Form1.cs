using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        int mSize;
        TextBox[][] matrixInput;
        int[][] matrix;
        public Form1()
        {
            InitializeComponent();
            mSize = 0;
        }

        private void setSizeButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<mSize; i++)
            {
                for(int j=0; j< mSize; j++)
                {
                    this.Controls.Remove(matrixInput[i][j]);
                }
            }

            mSize = int.Parse(sizeInput.Text);
            matrixInput = new TextBox[mSize][];

            for (int i = 0; i < mSize; i++)
            {
                matrixInput[i] = new TextBox[mSize];
                for (int j = 0; j < mSize; j++)
                {
                    matrixInput[i][j] = new TextBox();
                    matrixInput[i][j].SetBounds(350 + j * 70, 10 + i * 70, 50, 50);
                    matrixInput[i][j].Multiline = true;
                    this.Controls.Add(matrixInput[i][j]);
                }
            }
        }

        private void sizeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendToServerButton_Click(object sender, EventArgs e)
        {
            

            matrix = new int[mSize][];
            for(int i=0; i<mSize; i++)
            {
                matrix[i] = new int[mSize];
                for(int j=0; j<mSize; j++)
                {
                    matrix[i][j] = int.Parse(matrixInput[i][j].Text);
                }
            }


            var proxy = XmlRpcProxyGen.Create<IClient>();
            proxy.Url = "http://127.0.0.1:8888/";

            matrix = proxy.matrixHandle(matrix);
            
            for(int i=0; i<mSize; i++)
            {
                for(int j=0; j< mSize; j++)
                {
                    matrixInput[i][j].Text = ""+matrix[i][j];
                }
            }

        }

    }
}
