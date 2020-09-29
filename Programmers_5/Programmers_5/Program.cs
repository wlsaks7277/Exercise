/*
 * 2016년 1월 1일은 금요일입니다. 2016년 a월 b일은 무슨 요일일까요? 
 * 두 수 a ,b를 입력받아 2016년 a월 b일이 무슨 요일인지 리턴하는 함수, solution을 완성하세요.
 * 요일의 이름은 일요일부터 토요일까지 각각 SUN,MON,TUE,WED,THU,FRI,SAT
 * 입니다. 예를 들어 a=5, b=24라면 5월 24일은 화요일이므로 문자열 TUE를 반환하세요.
 * 2016년 윤년
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            Console.WriteLine(s.solution(5,24));
        }
    }

    public class Solution
    {
        enum day {Fri = 1,Sat = 2, Sun = 3,  Mon = 4,Tue = 5, Wed = 6,Thu = 7};

        int[] month = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public string solution(int a, int b)
        {
            int sum = 0;
            for(int i =0 ; i<a-1; i++)
            {
                sum += month[i];
            }
            sum += b;
            string answer =  Enum.GetName(typeof(day), sum % 7);
            
            return answer;
        }
    }
}
