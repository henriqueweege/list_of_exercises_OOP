using Exercise8;
using Library;

namespace Exercise8Reparation
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void btn_StartApp_Click(object sender, EventArgs e)
        {
            InputManipulator manipulator = new InputManipulator();
            var primalVector = manipulator.ConvertVectorInputIntoList(tb_InsertPrimalVector.Text);
            VectorOfRealsCalculate calculation = new VectorOfRealsCalculate(primalVector);
            //F_VectorCalculations f_VectorCalculations = new F_VectorCalculations(tb_InsertPrimalVector.Text);
            //f_VectorCalculations.ShowDialog();
        }
    }
}