//문제 설명
//자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 solution 함수를 만들어 주세요.
//예를들어 N = 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.

//제한사항
//N의 범위 : 100,000,000 이하의 자연수
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            //Console.WriteLine(s.solution(123));
            Console.WriteLine(s.solution(987));
        }
    }
    public class Solution
    {
        public int solution(int n)
        {
            int val = 0;
            int gar = 0;
            int answer = 0;
            for (int i= 10; n/i!=0;)
            {
                val = n / i;//12 1
                gar = n % i;//3 2
                n = val;//12 1
                answer += gar;//3 2
            }
            answer += val;
            
            return answer;
        }
    }
}
