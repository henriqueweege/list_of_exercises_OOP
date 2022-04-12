namespace ClassExercise5
{
    public class StringManipulator
    {
        public List<string> TakeSpacesOff(string PHRASE)
        {
            if(PHRASE[PHRASE.Length-1] != 32)
            {
                PHRASE = PHRASE.Insert(PHRASE.Length-1, " ");
            }
            var words = new List<string>();
            var letters = new List<char>();
            var phrase = PHRASE;
            while (phrase.Length > 1)
            {
                var word = phrase.Substring(0, phrase.IndexOf(" "));
                phrase = phrase.Remove(0, word.Length+1);
                words.Add(word);
            }
            return words;
            // usar o subString para cortar a partir da posição 0, até (variavel que vai apontar para o caracter 32(usando index)) -1 posição

            //depois a gente usa o .remove() para tirar essa primeira parte da string, posição 0 como primeiro argumento, e o segundo argumento
            //sendo a quantidade de caracteres a serem tirados
        }





    }
}