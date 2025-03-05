using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            ////int Identity(int n)
            ////{
            ////    return n;
            ////}

            //foreach(var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var firstName = names.First(n => n.StartsWith("A"));
            //Console.WriteLine($"First name starting with A : {firstName}");



            ////매서드 구문 , 쿼리구문
            //int[] nums = { 5, 3, 8, 1 };

            ////매서드 구문
            //var sortedMethod = nums.OrderBy(n => n);
            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;
            //// Sort 
            //Console.WriteLine("Method syntax");
            //foreach (var n in sortedMethod)
            //    Console.WriteLine(n);

            //Console.WriteLine("Query syntax");
            //foreach (var n in sortedQuery)
            //    Console.WriteLine(n);




            //string[] words = { "apple", "banana", "cherry" };
            ////select() 로 길이 추출
            //var lengths = words.Select(w => w.Length);

            //foreach(var length in lengths)
            //{
            //    Console.WriteLine(length);
            //}

            ////select 개념
            ////Linq 쿼리 연산자 중 하나
            ////각 요소를 변환하여 새로운 컬렉션을 생성

            //var upperWords = words.Select(w => w.ToUpper());

            //foreach (var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}

            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (var d in data)
            //    sum += d;

            //Console.WriteLine(sum);


            //int count = data.Length;  //개수

            //Console.WriteLine($"Cout : {count}");

            //float[] dataAvg = { 80, 76, 65 };
            //double avg = dataAvg.Average();
            //Console.WriteLine($"Average: {avg:F2}");

            //int[] dataMax = { 55, 76, 65 };
            //int max = dataMax.Max();

            //Console.WriteLine($"Max :  {max}");

            //int[] dataMin = { 55, 76, 45 };

            //int min = dataMin.Min();

            //Console.WriteLine($"Min : {min}");


            //int[] data1 = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data[0];

            //foreach (var d in data1)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d;
            //}

            //Console.WriteLine($"Nearest to {target} : {nearest}");

            //int[] scores = { 90, 70, 50, 70, 60 };
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    int rank1 =1 ;

            //    for (int j = 0; j < scores.Length; j++)
            //    {
            //        if (scores[j] > scores[i])
            //            rank1++;
            //    }
            //    Console.WriteLine($"Score :{scores[i]}, Rank: {rank1}");
            //}

            int[] data = { 5, 2, 8, 1, 9 };
            Array.Sort(data);

            foreach (var d in data)
                Console.WriteLine(d);

            
            int target = 8;
            int index = 0;

            for (int i =0; i<data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index >= 0 ? $"found at index{index}" : "not found");

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            var groups = fruits.GroupBy(f => f[0]);
            foreach(var group in groups)
            {
                // 그룹의 key 첫 글자 출력
                Console.WriteLine($"Key : {group.Key}");
                
                // 그룹의 모든 요소 출력
                foreach(var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }


        }
    }
}
