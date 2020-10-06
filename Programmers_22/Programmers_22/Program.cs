/*
 * 문제 설명
함수 solution은 정수 n을 매개변수로 입력받습니다.
n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 
예를들어 n이 118372면 873211을 리턴하면 됩니다.

제한 조건
n은 1이상 8000000000 이하인 자연수입니다.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution(12124124));
        }
    }

    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;

            char[] c = n.ToString().ToCharArray();

            //Array 활용 하는 법
            Array.Sort(c);
            Array.Reverse(c);
            answer = long.Parse(new string(c));

            return answer;
        }
    }
}
