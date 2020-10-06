/*
 * 문제 설명
자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요. 예를들어 n이 12345이면 [5,4,3,2,1]을 리턴합니다.

제한 조건
n은 10,000,000,000이하인 자연수입니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            int[] t = s.solution(1024124);
            foreach (int e in t)
            {
                Console.Write(e);
            }
            
        }
    }

    public class Solution
    {
        public int[] solution(long n)
        {
            List<int> list = new List<int>();

            long val = n;
            long tra = 0;

            while(val>0)
            {
                tra = val % 10;
                val = val / 10;
                list.Add((int)tra);
            }
            int[] answer = list.ToArray();
            return answer;
        }
    }
}
