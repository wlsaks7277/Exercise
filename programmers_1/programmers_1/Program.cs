/*
 * 정수 배열 numbers가 주어집니다. 
 * numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 
 * 만들 수 있는 모든 수를 배열에 오름차순으로 담아 
 * return 하도록 solution 함수를 완성해주세요.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programmers_1
{
    class Program
    {
        int[] numbers1 = new int[] { 2, 1, 3, 4, 1 };
        int[] numbers2 = new int[] { 5, 0, 2, 7 };
        static void Main(string[] args)
        {
            Program pr= new Program();

            foreach(int n in pr.solution(pr.numbers1))
            {
                Console.Write(n);
            }

            Console.WriteLine();
            foreach (int n in pr.solution(pr.numbers2))
            {
                Console.Write(n);
            }
            pr.solution(pr.numbers2);

        }
        

        public int[] solution(int[] numbers)
        {
            List<int> list = new List<int>();
           for(int i=0; i<numbers.Length; i++)
            {
                for(int j=0; j < numbers.Length; j++)
                {
                    if (i != j) list.Add(numbers[i] + numbers[j]); 
                }
            }
            list= list.Distinct().ToList();
            list.Sort();

            int[] answer = list.ToArray();
            return answer;
        }
    }
}
