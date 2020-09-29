//문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 
//각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다.
//예를 들어 strings가[sun, bed, car] 이고 n이 1이면 
//각 단어의 인덱스 1의 문자 u, e, a로 strings를 정렬합니다.

//    제한 조건
//strings는 길이 1 이상, 50이하인 배열입니다.
//strings의 원소는 소문자 알파벳으로 이루어져 있습니다.
//strings의 원소는 길이 1 이상, 100이하인 문자열입니다.
//모든 strings의 원소의 길이는 n보다 큽니다.
//인덱스 1의 문자가 같은 문자열이 여럿 일 경우, 사전순으로 앞선 문자열이 앞쪽에 위치합니다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            string[] t = { "abce", "abcd", "cdx" };
            s.solution( t, 2);
        }

        public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                List<string> list = new List<string>();
                List<string> temp = new List<string>();
                

                string[] sub = new string[strings.Length];
                for (int i =0; i< strings.Length; i++)
                {
                    sub[i] = strings[i].Substring(n);
                    temp.Add(sub[i]);
                    
                }
                temp.Sort();
                foreach(string t in temp)
                {
                    Console.Write(t+"----------");
                }
                Console.WriteLine();
                for (int i = 0; i < sub.Length; i++)
                {
                    for (int j = 0; j < temp.Count; j++)
                    {
                        if (sub[i]== temp[j])
                        {
                            //if(list.Exists(x => x == strings[j]) != true)
                            list.Add(strings[j]);
                        }
                    }
                }

                foreach (string a in list)
                {
                    Console.Write(a + "-----------");
                }
                Console.WriteLine();
                return list.ToArray();
            }
        }
    }
}
