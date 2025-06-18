using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Mathematic;


namespace TestLU
{
    public partial class Form1 : Form
    {
        LinearEquation linEq;

        public Form1()
        {            
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            label_Answer.Text = "";
            double[][] a = new double[2][];            
            for (int i=0; i<2; i++)
            {
                a[i] = new double[2];
            }
            a[0][0] = Convert.ToDouble(textBox_a11.Text);
            a[0][1] = Convert.ToDouble(textBox_a12.Text);
            a[1][0] = Convert.ToDouble(textBox_a21.Text);
            a[1][1] = Convert.ToDouble(textBox_a22.Text);

            double[] u = new double[2];

            u[0] = Convert.ToDouble(textBox_u1.Text);
            u[1] = Convert.ToDouble(textBox_u2.Text);

            linEq = new LinearEquation(a);
            double[] ans = linEq.X(u);

            Matrix matr = new Matrix(linEq.LeftMatr);
            double[][] testINV=matr.Inverse;
            double[][] test2 = matr.TransponMatrix();//AlgAdditionaL(0, 1);

            label_Answer.Text += "=" + ans[0].ToString();
            label_Answer.Text += "; " + ans[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Pow(-1, 0 + 0).ToString());
        }
    }
}
