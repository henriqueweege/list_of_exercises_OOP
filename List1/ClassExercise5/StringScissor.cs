namespace Library
{
    public class StringScissor
    {
        public List<string> TakeSpacesOff(string PHRASE)
        {

            var words = new List<string>();
            var phrase = PHRASE;
            var count = 0;
            while (phrase.Length > 1)
            {
                if (phrase[0] == ' ')
                {
                    phrase = phrase.Remove(0, 1);
                    continue;
                }
                if (phrase.IndexOf(" ") == -1 && count > 0)
                {
                    var finalWord = phrase.Substring(0, phrase.Length);
                    phrase = phrase.Remove(0, finalWord.Length);
                    words.Add(finalWord);
                }
                else
                {
                    var word = phrase.Substring(0, phrase.IndexOf(" "));
                    phrase = phrase.Remove(0, word.Length + 1);
                    words.Add(word);
                    count++;
                }
            }
            return words;
        }
    }
}