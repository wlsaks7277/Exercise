//문제 설명
//문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 확인해주는 함수, 
//    solution을 완성하세요.예를 들어 s가 a234이면 False를 리턴하고 1234라면 True를 리턴하면 됩니다.

//제한 사항
//s는 길이 1 이상, 길이 8 이하인 문자열입니다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution("1234"));
        }
        public class Solution
        {
            public bool solution(string s)
            {
                bool answer = false;
                if (s.Length==4 || s.Length == 6)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        if (s[i] - '0' >= 0 && s[i] - '0' <= 9)
                        {
                            answer = true;

                        }
                        if (s[i]-'0' >=0 && s[i]-'0'<= 9)
                        {
                            answer = true;
                            
                        }
                        //부동소수점 활용 char -> int
                        //if ((int)char.GetNumericValue(s[i])>=0 && (int)Char.GetNumericValue(s[i])<=9) 
                        //{
                        //    answer = true;
                            
                        //}

                    }
                }
                
                return answer;
            }
        }
    }
}
