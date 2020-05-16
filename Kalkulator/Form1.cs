using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment1
{
    public partial class Form1 : Form
    {
        public bool isResultClicked = false;
        public Form1()
        {
            InitializeComponent();
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperand_Click(object sender, EventArgs e)
        {
            if(textBoxResult.Text == "0" || isResultClicked == true)
            {
                textBoxResult.Clear();
                isResultClicked = false;
            }
            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if(isResultClicked == true)
            {
                textBoxResult.Text = "0";
                isResultClicked = false;
            }
            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            isResultClicked = true;
            DataTable table = new DataTable();
            String expression = textBoxResult.Text;
            double result = Convert.ToDouble(table.Compute(expression, String.Empty));
            textBoxResult.Text = (result).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isResultClicked = false;
            textBoxResult.Text = "0"; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String result = textBoxResult.Text;
            if (result.Length > 0)
                textBoxResult.Text = result.Substring(0, result.Length - 1);
            else
                textBoxResult.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
