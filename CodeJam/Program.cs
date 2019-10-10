using System;

namespace CodeJam
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the output of this code?
            Test1();//40

            /*
            What is the output?
            Exception
            Jen
            Bob
            */
            Test2();//Jen

            //What is the output of this code?
            Test3();//goblin

            //What is the output of this code?
            Test4();//hi

            //What is the output of this code?
            //s
            //a
            Test5();

            /*
            What is the output of this code?
            Infinity
            -Infinity
            NaN
            Compilation error
            */
            Test6();//-8 -Infinity

            /*
            What is the output of this code?
            45
            44
            566
            44.56
            */
            Test7();//44

            /*
            What is the correct extension for c# file? 
            .cs
            .exe
            .c#
            .c
            */

            /*
            Can an interface be instantiated directly?
            R/ Yes
               No
            */

            //What is the output of this code?
            Test8();//7

            //What is the output of this code?
            Test9();//6

            //What is the output of this code?
            Test10();//4

            //Which of the following is a valid array declaration containing 3 elements?
            //int a[] = int { 0,0,0 };
            //int[] a = int[3];
            //int[] a = new int { 0, 0, 0 };
            //R/ int[] a = new int[3];  

            /*
            Which of the following operator returns the size of a data type in C#?
            typeof
            set
            get
            R/ sizeof
            */

            //What is the output of this code?
            Test11();//1

            //What is the output of this code?
            Test12();//15

            //What is the output of this code?
            Test13();//3

            //How many times will the following loop run?
            Test14();//2

            //What is the output of this code?
            Test15();//19

            //What is the output of this code?
            Test16();//26

            //What is the output of this code?
            Test17();//1

            //What is the output of this code?
            Test18();//5

            //What will be the result?
            /*
            12
            11
            14
            13
            */
            Test19();//13

            //What is the output of this code?
            Test20();

            //What is the output of this code?
            /*
            h
            this
            error
            is
            */
            Test21();//h

            //What is the output of this code?
            Test22();//9

            //What is the output of this code?
            /*
            str
            str null
            null str
            null null
            */
            Test23();//str

            //What is the output of this code?
            /*
            Won't compile
            Output is 5
            Output is 0
            Output is 9
            */
            //Test24();

            //What is the output of this code?
            Test25();//4

            /*
            How many values a bool can accept?
            0
            it depends
            R/ 2
            1
            */

            //What is the output of this code?
            Test26();//25

            //What is the output of this code?
            /*
            2.66
            2.65789
            2.6
            0.00
            */
            Test27();//2,66

            //What is the output of this code?
            Test28();//0

            //What is the output of this code?
            Test29();//20

            //What is the output of this code?
            Test30();//15

            //What is the output of this code?
            Test31();//15

            //What is the output of this code?
            Test32();//4

            //What is the output of this code?
            Test33();//1

            /*
            Which of these data types take a number?
            R/ double
            string
            bool
            R/ int
            */

            //What is the output of this code?
            Test34();//11

            //What is the output of this code?
            Test35();//00

            //What is the output of this code?
            Test36();//1

            //What is the output of this code?
            /*
            :(
            R/ :)
            */
            Test37();

            //What is the output of this code?
            Test38();//ab381

            //What is the output of this code?
            Test39();//utonom

            //What is the output of this code?
            Test40();//2

            Console.Read();
        }

        public static void Test()
        {
            Console.WriteLine();
        }

        public static void Test40()
        {
            int[,] tab1 = new int[2, 2] { { 2, 3 }, { 7, 4 } };
            int[,] tab2 = new int[2, 2] { { 8, 1 }, { 6, 5 } };

            Console.WriteLine(tab1[1, 0] % tab2[1, 1]);
        }

        public static void Test39()
        {
            string x = "";
            string y = "autonoma";

            foreach (char c in y)
            {
                if (c > 'f')
                {
                    x += c;
                }
            }

            Console.WriteLine(x);
        }

        public static void Test38()
        {
            int a = 20;
            int b = 68;
            int c = 381;
            Console.WriteLine("a" + "b" + c);
        }

        public static void Test37()
        {
            string myname = "user";
            if (myname.Contains("us"))
                Console.WriteLine(":)");
            else
                Console.WriteLine(":(");
        }

        public static void Test36()
        {
            int x = 2;
            int y = ++x + x++;
            int z = --y - x--;
            Console.WriteLine(z);
        }

        public static void Test35()
        {
            Console.WriteLine("0" + "0");
        }

        public static void Test34()
        {
            int x = 5;
            x += ++x;
            Console.WriteLine(x);
        }

        public static void Test33()
        {
            int x = 15;
            x /= 7;
            x %= 1;

            Console.WriteLine(++x);
        }

        public static void Test32()
        {
            Console.WriteLine(sizeof(int));
        }

        public static void Test31()
        {
            int n = 10;
            int x = 15;

            if (n > x)
                Console.WriteLine(n);
            else
                Console.WriteLine(x);
        }

        public static void Change(ref int x, ref int y)
        {
            y++;
            ++x;
        }

        public static void Test30()
        {
            int a = 13;
            Change(ref a, ref a);

            Console.WriteLine(a);
        }

        public static void Test29()
        {
            int x = 10;
            do
            {
                x *= 2;
            } while (x <= 5);

            Console.WriteLine(x);
        }

        public static void Test28()
        {
            int? num01 = null;
            num01 = 0;

            Console.WriteLine(num01);
        }

        public static void Test27()
        {
            float num = 2.65789f;
            string f = num.ToString("0.00");

            Console.WriteLine(f);
        }

        public static void Test26()
        {
            int x = 1;
            int[] arr = { 5, 7, 4, 2 };
            Array.Reverse(arr);
            x += arr[1];
            x *= arr[3];

            Console.WriteLine(x);
        }

        public static void Test25()
        {
            int x = 3;
            int y = 6;
            int z = x + y % 2;

            Console.WriteLine(++z);
        }

        public static void Test24()
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.write line(i);
                i = -5;
            }
        }

        public static void Test23()
        {
            string str = null;

            Console.WriteLine(str + "str");
        }

        public static void Test22()
        {
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                j = i;
            }

            Console.WriteLine(j);
        }

        public static void Test21()
        {
            string[,] listOfWords = {
                { "this", "is" },
                { "2d", "array" }
            };

            Console.WriteLine(listOfWords[0, 0][1]);
        }

        public static void Test20()
        {
            int x = 1;
            int[,] m = new int[,] {
                { 2,1,3 },
                { 3,5,4 },
                { 4,3,5 }
            };

            for (int i = 0; i <= 2; i++)
            {
                x *= m[i, 2 - i];
            }

            Console.WriteLine(x);
        }

        public static void Test19()
        {
            int n;
            n = (7 * 5 > 6 * 6)
                ? (7 * 9 > 8 * 8) ? 11 : 12
                : (7 * 8 > 9 * 6) ? 13 : 14;

            Console.WriteLine(n);
        }

        public static void Test18()
        {
            int a = 4;
            int b = ++a;

            if (b > 5)
                Console.WriteLine(b);
            else
                Console.WriteLine(a);
        }

        public static void Test17()
        {
            int a = 9;
            int b = a / 18;
            ++b;

            Console.WriteLine(b);
        }

        public static void Test16()
        {
            int x = 6; int y = 13;
            int z = y % x + 5 * 5;

            Console.WriteLine(z);
        }

        public static void Test15()
        {
            int y = 9;
            int x = y++;

            Console.WriteLine(x + y);
        }

        public static void Test14()
        {
            int a = 5;
            do
            {
                Console.WriteLine(a);
            } while (++a <= 6);
        }

        public static void Test13()
        {
            int x = 6, y = 4;
            int z = ++x - y--;

            Console.WriteLine(z);
        }

        public static void Test12()
        {
            int x = 10;
            do
            {
                x += 5;
            } while (x < 15);

            Console.WriteLine(x);
        }

        public static int increase(int a)
        {
            a += 5;
            return a;
        }

        public static void Test11()
        {
            int a = 1, b;
            b = increase(a);
            Console.WriteLine(a);
        }

        public static void Test1()
        {
            int x = 8;
            int y = 5;
            int z = (x > y) ? x * y : x + y;
            Console.WriteLine(z);
        }

        class P
        {
            public string N1
            {
                get { return "Jen"; }
                set { }
            }
        }

        public static void Test2()
        {
            P p = new P();
            p.N1 = "Bob";
            Console.WriteLine(p.N1);
        }

        public static void Test3()
        {
            string[] race = new string[] { "dwarf", "elf", "goblin", "human" };
            Console.WriteLine(race[2]);
        }

        public static void Test4()
        {
            int x = 1;
            string output = (x == 1) ? "hi" : "bye";
            Console.WriteLine(output);
        }

        class Person
        {
            public string name { get; set; }
            public string country { get; set; }

            public Person()
            {
                name = "Petar";
                country = "Bulgaria";
            }
        }

        public static void Test5()
        {
            Person p1 = new Person();
            p1.name = "Gosho";
            Console.WriteLine(p1.name[2]);
            Console.WriteLine(p1.country[4]);
        }

        public static void Test6()
        {
            var x = 2 / -0.0;
            Console.WriteLine(x);
        }

        public static void Test7()
        {
            int y;
            double x = 44.566;
            y = (int)(x);
            Console.WriteLine(y);
        }

        public static void Test8()
        {
            int n = 5;
            int m = 7;
            int z = 6;
            if (++n < m && z == n++)
            {
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine(n);
            }
        }

        public static void Test9()
        {
            int i;
            for (i = 1; i < 9; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                if (i % 3 == 0)
                {
                    break;
                }
            }
            Console.WriteLine(i);
        }

        public static void Test10()
        {
            int x = 16;
            int y = 3;
            x %= y * 2;
            Console.WriteLine(x++);
        }


    }
}
