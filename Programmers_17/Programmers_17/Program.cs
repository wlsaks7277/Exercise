﻿//문제 설명
//정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수, solution을 완성해주세요.

//제한 사항
//n은 0 이상 3000이하인 정수입니다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution(5));
        }
    }
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            
            for(int i =1; i<=n; i++)
            {
                
                if (n % i == 0) answer += i;
            }
            
            return answer;
        }
    }
}
