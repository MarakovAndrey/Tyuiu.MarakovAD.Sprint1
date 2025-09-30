using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MarakovAD.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string res = "";
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                string reversedLowerWord = new string(lowerWord.Reverse().ToArray());
                if (lowerWord == reversedLowerWord)
                {
                    res += word;
                }
            }
            return res;
            //value = value.ToLower();
            //char[] charArray = value.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedValue = new string(charArray);
            //if (value.Equals(reversedValue)) {
            //    return value;
        }
    }
}
