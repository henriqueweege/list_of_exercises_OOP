namespace Library
{
    public class InputOutputManipulator
    {
        public List<double> ConvertStringVectorInputToListVectorInput(string stringVectorInput)
        {
            var listVectorInput = new List<double>();
            string[] cutInput = stringVectorInput.Split(',');
            foreach(string c in cutInput)
            {
                listVectorInput.Add(double.Parse(c));
            }
            return listVectorInput;
        }
        public string ConvertListVectorToStringVector(List<double> listVector)
        {
            var stringVectorInput = "";
            foreach(var num in listVector)
            {
                stringVectorInput = stringVectorInput  + num.ToString() + "; ";
            }
            return stringVectorInput;
        }

    }
}