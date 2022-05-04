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
        public string anotherVector;
        List<double> primalVector;
        InputOutputManipulator manipulator;
        VectorOfRealsCalculate calculation;


        public F_VectorCalculations(string input)
        {
            InitializeComponent();
            manipulator = new InputOutputManipulator();
            primalVector = manipulator.ConvertStringVectorInputToListVectorInput(input);  
            calculation = new VectorOfRealsCalculate(primalVector);
            anotherVector = " ";
        }

        private void bt_MultiplyVectors_Click(object sender, EventArgs e)
        {

            F_AnotherVectorInput f_AnotherVectorInput = new F_AnotherVectorInput(this);
            f_AnotherVectorInput.ShowDialog();
            try
            {
                var anotherVectorList = manipulator.ConvertStringVectorInputToListVectorInput(anotherVector);
                var result = calculation.MultiplyVectors(anotherVectorList);
                textBox1.Text = $"Result of multiplycation {manipulator.ConvertListVectorToStringVector(result)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("The input was in a not accepted format. " +
                    "It must contain just numbers, and be comma separated");
            }

            

        }

        private void bt_CreateNewVector_Click(object sender, EventArgs e)
        {
            F_AnotherVectorInput f_AnotherVectorInput = new F_AnotherVectorInput(this);
            f_AnotherVectorInput.ShowDialog();
            try
            {
                var anotherVectorList = manipulator.ConvertStringVectorInputToListVectorInput(anotherVector);
                calculation.CreateNewObject(anotherVectorList);
                var result = calculation._vector;
                textBox1.Text = $"The new Vector is {manipulator.ConvertListVectorToStringVector(result)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("The input was in a not accepted format. " +
                    "It must contain just numbers, and be comma separated");
            }

        }

        private void bt_EvenNumbersCounter_Click(object sender, EventArgs e)
        {
            var vector = calculation._vector;
            var result = calculation.EvenNumbersCounter(vector);
            textBox1.Text = $"Quantity of even numbers: {result}";
        }

        private void bt_VectorInversor_Click(object sender, EventArgs e)
        {
            var vector = calculation._vector;
            var result = calculation.VectorInversor(vector);
            textBox1.Text = $"The invertion of the vector is: {manipulator.ConvertListVectorToStringVector(result)}";

        }

        private void bt_BiggestDifferenceBetweenElements_Click(object sender, EventArgs e)
        {
            var vector = calculation._vector;
            var result = calculation.BiggestDifferenceBetweenElements(vector);
            textBox1.Text = $"The invertion of the vector is: {result}";
        }
    }
}
