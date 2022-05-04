using Library;
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
    public partial class F_VectorCalculations : Form
    {
        public F_VectorCalculations(string input)
        {
            InputManipulator manipulator = new InputManipulator();
            var primalVector = manipulator.ConvertVectorInputIntoList(input);
            VectorOfRealsCalculate calculation = new VectorOfRealsCalculate(primalVector);
            InitializeComponent();
        }
    }
}
