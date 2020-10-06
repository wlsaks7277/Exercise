/*
 * 문제 설명
임의의 양의 정수 n에 대해, n이 어떤 양의 정수 x의 제곱인지 아닌지 판단하려 합니다.
n이 양의 정수 x의 제곱이라면 x+1의 제곱을 리턴하고,
n이 양의 정수 x의 제곱이 아니라면 -1을 리턴하는 함수를 완성하세요.

제한 사항
n은 1이상, 50000000000000 이하인 양의 정수입니다.
입출력 예
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_23
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution(169));
        }
    }

    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;
            long val = 0;
            for (int i=1; i<n+1; i++)
            {
                val = n / i;
                if(val*val==n)
                {
                    answer = val+1;
                    answer *= answer;
                }
            }
            if (answer == 0) return -1;
            return answer;
        }
    }
}
