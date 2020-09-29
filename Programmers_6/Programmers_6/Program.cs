/*
 * 단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
 * */

/*
    * 
    * substring q   w  e  r
    *          ↑ ↑ ↑ ↑ ↑
    *          0  1  2  3  4  
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution("qwer"));
        }
    }
             

    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            int num = s.Length % 2;
            int sub = s.Length / 2;
            
            if(num == 1)
            {
                answer = s.Substring(sub, 1);
            }

            else
            {
                answer = s.Substring(sub-1, 2);
            }
            
            return answer;
        }
    }
}
