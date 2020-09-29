//문제 설명
//길이가 n이고, 수박수박수박수....와 같은 패턴을 유지하는 문자열을 리턴하는 함수,
//solution을 완성하세요.예를들어 n이 4이면 수박수박을 리턴하고 3이라면 수박수를 리턴하면 됩니다.

//제한 조건
//n은 길이 10,000이하인 자연수입니다.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution(4));
        }
    }
    public class Solution
    {
        public string solution(int n)
        {
            bool c = false;
            string answer = "";
            if (n % 2 == 0) c = false;
            else c=true;
            for (int i = 0; i < n / 2; i++)
            {
                answer = String.Concat(answer, "수박");
            }

            if(c == true) answer = String.Concat(answer, "수");
            return answer;
        }
    }
}
