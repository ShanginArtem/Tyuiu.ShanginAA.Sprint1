using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShanginAA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            var a = value.Split(' ');
            var result = "";
            foreach (var word in a)
            {
                if (word.Contains("нн"))
                {
                    result += " " + word;
                }
            }

            return result.Substring(1);
        }
    }
}
