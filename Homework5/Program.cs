using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Number3();
        }

        static void Number2()
        {
            string test = "Hello World!";
            Console.WriteLine(test.CountChar());
        }

        static void Number3() // не получилось сделать :(
        {
            List<int> test = new List<int>();
            test.Add(2);
            test.Add(3);
            test.Add(5);
            //test.Add(2);
            //test.Add(3);
            //test.Add(3);
            //test.Add(3);
            //test.Add(1);

            Dictionary<int, int> testDict = Number3A(test);

            foreach (KeyValuePair<int, int> answer in testDict)
            {
                Console.WriteLine($"{answer.Key} - {answer.Value}");
            }
        }
        static Dictionary<int,int> Number3A(List<int> myList)
        {
            Dictionary<int, int> dict = new Dictionary<int,int>();

            int count = 1;

            for(int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < myList.Count; j++)
                {
                    if(myList[i] == myList[j])
                    {
                        dict.Add(myList[i], count);
                        myList.RemoveAt(j);
                        j--;
                        count++;
                    }
                }
                count = 1;
            }


            return dict;
        }

        static void Number4()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
            var d = dict.OrderBy(pair => pair.Value);
            foreach (var pair in d)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

        }
    }
}
