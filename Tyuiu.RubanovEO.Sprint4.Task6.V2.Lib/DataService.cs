
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RubanovEO.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            List<string> ans = new List<string>();
            foreach (string s in array)
            {
                if (s.Length > 5)
                {
                    ans.Add(s);
                }
            }
            return ans.ToArray();
        }
    }
}
