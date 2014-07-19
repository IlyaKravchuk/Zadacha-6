using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
        class Program
        {
            private static List<Pyramid> pyramides = new List<Pyramid>();

            static void Main(string[] args)
            {
                Pyramid pyr1 = new Pyramid(10, 20);
                Pyramid pyr2 = new Pyramid(8, 14);
                Pyramid pyr3 = new Pyramid(9.5, 11);
                Pyramid pyr4 = new Pyramid(2, 10);
                Pyramid pyr5 = new Pyramid(14, 40);
                Pyramid pyr6 = new Pyramid(6.9, 13.7);
                pyramides.Add(pyr1);
                pyramides.Add(pyr2);
                pyramides.Add(pyr3);
                pyramides.Add(pyr4);
                pyramides.Add(pyr5);
                pyramides.Add(pyr6);

                Console.WriteLine("Список\n");
                Print(pyramides);

                Console.WriteLine("\nВведите номер критерия сортировки\n1.По длине грани\n2.По длине стороны основания");
                string s = Console.ReadLine();
                int x = int.Parse(s);
                Sort(x);

                Console.WriteLine("\nПосле сортировки\n");
                Print(pyramides);

                Console.WriteLine("\nВведите позицию, в которую нужно добавить элемент (от 0 до {0})\n", pyramides.Count - 1);
                s = Console.ReadLine();
                int q = int.Parse(s);

                if (q < 0 || q > pyramides.Count)
                {
                    Console.WriteLine("Неправильно введён номер позиции");
                }

                Console.WriteLine("\nПосле добавления элементов в конец и в произвольную позицию списка\n");
                pyramides.Add(new Pyramid(4, 4.9));
                pyramides.Insert(q, new Pyramid(5, 8));
                Print(pyramides);

                Console.WriteLine("\nПосле удаления ранее добавленных\n");
                pyramides.Remove(pyramides[pyramides.Count - 1]);
                pyramides.RemoveAt(q);
                Print(pyramides);

                Console.WriteLine("\nВведите критерий поиска\n1.По длине грани\n2.По длине стороны основания");
                s = Console.ReadLine();
                x = int.Parse(s);
                Console.WriteLine("\nВведите значение параметра поиска\n");
                s = Console.ReadLine();
                int e = int.Parse(s);
                int index = 0;
                if (x == 1)
                    index = pyramides.FindIndex(i => i.Edge == e);
                else if (x == 2)
                    index = pyramides.FindIndex(i => i.Basis == e);
                else
                    Console.WriteLine("\nТакого критерия не существует\n");

                Console.WriteLine("\nНайденный элемент поиска\n");
                Console.WriteLine("{0} {1}", pyramides[index].Edge, pyramides[index].Basis);

                Console.WriteLine("\nСписок пуст");
                pyramides.Clear();

                Console.ReadKey();
            }

            static void Sort(int x)
            {
                for (int i = 1; i < pyramides.Count; i++)
                {
                    for (int j = 0; j < pyramides.Count - i; j++)
                    {
                        if (x == 1)
                        {
                            if (pyramides[j].Edge > pyramides[j + 1].Edge)
                            {
                                Pyramid b = pyramides[j];
                                pyramides[j] = pyramides[j + 1];
                                pyramides[j + 1] = b;
                            }
                        }
                        else
                        {
                            if (pyramides[j].Basis > pyramides[j + 1].Basis)
                            {
                                Pyramid b = pyramides[j];
                                pyramides[j] = pyramides[j + 1];
                                pyramides[j + 1] = b;
                            }
                        }
                    }
                }
            }

            static void Print(List<Pyramid> b)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    Console.Write(" Длина грани пирамиды = {0} |", b[i].Edge);
                    Console.Write(" Длина стороны основания = {0}", b[i].Basis);
                    Console.WriteLine();
                }
            }
        }
    }
}
