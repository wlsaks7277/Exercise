/*
 * 수포자는 수학을 포기한 사람의 준말입니다. 수포자 삼인방은 모의고사에 수학 문제를 전부 찍으려 합니다. 
 * 수포자는 1번 문제부터 마지막 문제까지 다음과 같이 찍습니다.

1번 수포자가 찍는 방식: 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, ...
2번 수포자가 찍는 방식: 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5, ...
3번 수포자가 찍는 방식: 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, ...

1번 문제부터 마지막 문제까지의 정답이 순서대로 들은 배열 answers가 주어졌을 때, 
가장 많은 문제를 맞힌 사람이 누구인지 배열에 담아 return 하도록 solution 함수를 작성해주세요.
 * */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_2
{
    class Program
    {
        int[] num = new int[] { 1,3,2,4,2};
        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] tmep = pr.solution(pr.num);
            foreach(int i in tmep)
            {
                Console.Write(i +" ");
            }
            
            Console.WriteLine();
        }
        public int[] solution(int[] answers)
        {
            int[] answer = new int[] { };

            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5, };
            int[] arr3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int[] count = new int[3];

            List<int[]> list = new List<int[]>();
            list.Add(arr1);
            list.Add(arr2);
            list.Add(arr3);
            
            for(int i = 0; i<answers.Length; i++)
            {
                if(answers[i] == list[0][ i % arr1.Length])
                {
                    count[0]++;
                }
                if(answers[i] == list[1][ i % arr2.Length])
                {
                    count[1]++;
                }
                if(answers[i] == list[2][ i % arr3.Length])
                {
                    count[2]++;
                }
            }

            

            int winner = count[0];
            for (int i=0; i<count.Length; i++)
            {
                if (winner < count[i]) winner = count[i];
                
            }
            List<int> win = new List<int>();
            for(int i=0, j=0; i<count.Length; i++)
            {
                if (winner == count[i])
                {
                    win.Add(i+1);
                    
                }
            }
            answer = win.ToArray();
            return answer;
        }
    }

    
}
