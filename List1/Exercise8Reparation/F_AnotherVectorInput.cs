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
    public partial class F_AnotherVectorInput : Form
    {
        public F_VectorCalculations _vectorCalculations;
        public F_AnotherVectorInput(F_VectorCalculations vectorCalculations)
        {
            InitializeComponent();
            _vectorCalculations = vectorCalculations;
        }

        private void bt_AnotherVector_Click(object sender, EventArgs e)
        {
            
            
                _vectorCalculations.anotherVector = tb_AnotherVector.Text;
                F_AnotherVectorInput.ActiveForm.Close();
            

        }
    }
}
