using System;
using System.Collections.Generic;

namespace AngryAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            AngryAnimalProvider animalProvider = new AngryAnimalProvider();
            animalProvider.Run();

            //int[,] a = new int[2, 1];
            //int[,] b = new int[2, 1];
            //Console.WriteLine(a == b);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }

    public class AngryAnimalProvider
    {
        private int n, m;
        private int[] a, b;

        public void Run()
        {
            //int[] inputs = new int[] { 5, 2, 1, 2, 2, 3, 5 };
            //int[] inputs = new int[] { 3, 3, 1, 2, 3, 3, 3, 3, 1 };
            int[] inputs = new int[] { 4, 2, 1, 2, 2, 3, 4 };
            ParseInput(inputs);
            //Console.WriteLine(JoinList(new int[] {6, 1, 2, 3 }));
            List<int> internalList = null;
            List<string> resultList = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                resultList.Add(i.ToString());
                internalList = new List<int> { i };
                for (int j = i + 1; j <= n; j++)
                {
                    if (IsEnemy(i, j))
                        break;
                    internalList.Add(j);
                    resultList.Add(JoinList(internalList.ToArray()));
                }

                var item = JoinList(internalList.ToArray());
                if (!resultList.Contains(item))
                    resultList.Add(item);
            }
            //string.Format("{{{0}}}", string.Join(",", numbers));
            Console.WriteLine("Groups = " + string.Join(" | ", resultList));
            Console.WriteLine("Group Count " + resultList.Count);
        }

        void ParseInput(int[] inputs)
        {
            int pos = 0;
            n = inputs[pos++];
            m = inputs[pos++];
            a = GetEnemies(inputs, ref pos, m);
            m = inputs[pos++];
            b = GetEnemies(inputs, ref pos, m);

            Console.WriteLine("n = " + n);
            Console.WriteLine("m = " + m);
            Console.WriteLine("a = " + JoinList(a));
            Console.WriteLine("b = " + JoinList(b));
        }

        int[] GetEnemies(int[] inputs, ref int startPos, int length)
        {
            int[] a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = inputs[startPos];
                ++startPos;
            }
            return a;
        }

        string JoinList(int[] numbers)
        {
            return string.Join(",", numbers);
        }

        bool IsEnemy(int x, int y)
        {
            var f = string.Format("{0}{1}", x, y);
            for (int i = 0; i < m; i++)
            {
                //for (int j = 0; j < m; j++)
                {
                    var f1 = string.Format("{0}{1}", a[i], b[i]);
                    var f2 = string.Format("{0}{1}", b[i], a[i]);
                    var isTrue = f == f1 || f == f2;
                    if (isTrue)
                        return true;
                }
            }
            return false;
        }
    }
}
