//문제 설명
//어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다.
//예를 들어 AB는 1만큼 밀면 BC가 되고, 3만큼 밀면 DE가 됩니다.z는 1만큼 밀면 a가 됩니다.
//문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수, solution을 완성해 보세요.

//제한 조건
//공백은 아무리 밀어도 공백입니다.
//s는 알파벳 소문자, 대문자, 공백으로만 이루어져 있습니다.
//s의 길이는 8000이하입니다.
//n은 1 이상, 25이하인 자연수입니다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.solution("abc",1));
        }
    }
    // string s를 char 배열로 받을 때는 ToCharArray , char 배열을 string으로 받을때는 new string
    public class Solution
    {
        public string solution(string s, int n)
        {
            char[] ch = s.ToCharArray();

            for(int i=0; i<s.Length; i++)
            {
                ch[i] = (char)(ch[i] + n);
            }

            string answer = new string(ch);
            return answer;
        }
    }
}
