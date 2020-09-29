//문제 설명
//1부터 입력받은 숫자 n 사이에 있는 소수의 개수를 반환하는 함수, solution을 만들어 보세요.

//소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다.
//(1은 소수가 아닙니다.)

//제한 조건
//n은 2이상 1000000이하의 자연수입니다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution(10));
        }
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                for (int i = 1; i < n; i++)
                {
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0) count++;
                    }
                    if (count == 2) answer++;
                }
                
                return answer;
            }
        }
    }
}
