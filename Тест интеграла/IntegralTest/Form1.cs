using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntegralTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<WorkWithFunct.ValuePoint> values = new List<WorkWithFunct.ValuePoint>();

            for (double arg = 0.01; arg < 15; arg+=0.01)
            {
                values.Add(new WorkWithFunct.ValuePoint(arg, (arg-1) * Math.Sin(arg)/Math.Pow(arg, 5.0)));
            }

            label1.Text = String.Format("{0:e3}", Mathematic.MathematicOperations.IntegraL(values, 0.01, 15));
            label_integr_trap.Text = String.Format("{0:e3}", Mathematic.MathematicOperations.IntegraL_trap(values, 0.01, 15));

            
        }

        private void button_integr_trap_Click(object sender, EventArgs e)
        {
            List<WorkWithFunct.ValuePoint> values = new List<WorkWithFunct.ValuePoint>();

            for (double arg = 0; arg <= 1; arg += 0.01)
            {
                values.Add(new WorkWithFunct.ValuePoint(arg, 1 / (1 + arg)));
            }

            label_integr_trap.Text = String.Format("{0:e3}", Mathematic.MathematicOperations.IntegraL_trap(values, 0, 1));
            label1.Text = String.Format("{0:e3}", Mathematic.MathematicOperations.IntegraL(values, 0, 1));

           
        }
    }
}
