using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void bt_PrimalVector_Click(object sender, EventArgs e)
        {
            try
            {
                F_VectorCalculations f_VectorCalculations = new F_VectorCalculations(tb_PrimalVector.Text);
                f_VectorCalculations.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("The input was in a not accepted format. " +
                    "It must contain just numbers, and be comma separated");
            }
            
        }
    }
}
