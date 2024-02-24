using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtExpression1.Text);
            int value2 = int.Parse(txtExpression2.Text);

            txtResult.Text = (value1 + value2).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtExpression1.Text);
            int value2 = int.Parse(txtExpression2.Text);

            txtResult.Text = (value1 - value2).ToString();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtExpression1.Text);
            int value2 = int.Parse(txtExpression2.Text);

            txtResult.Text = (value1 * value2).ToString();
        }
        // コメント
        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(txtExpression1.Text);
            double value2 = double.Parse(txtExpression2.Text);

            txtResult.Text = (value1 / value2).ToString();

        }
    }
}
