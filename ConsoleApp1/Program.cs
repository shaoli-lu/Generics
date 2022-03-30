using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Generics
{
    internal class Program
    {
        int n = 3;

        static void Main(string[] args)
        {
            //// while loop - not define times of iteration - infinite sentinel value user input
            //int i = 0; //initilization
            //while (i<10) //condition
            //{
            //    Console.WriteLine(i);
            //    i++; //update
            //}
            //Console.WriteLine("Hello World!");

            //// Do While - execute at least once
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while ( i < 10);

            ////For loop - array or collection
            //for (int i=9; i>=0; i-=2)
            //{
            //    Console.WriteLine(i);
            //};

            ////nesting
            //for(int i = 9; i>= 0; i--)
            //{
            //    Console.WriteLine(i);
            //    bool logging = false;
            //    if(i==7)
            //    {
            //        if(logging == true) { 
            //        Console.WriteLine($"Found {i}");
            //        }
            //    }
            //}

            ////nested For loop
            //for (int i = 9; i >= 0; i--)
            //{
            //    for (int k = i; k >= 0; k--)
            //    {
            //        if(k==3)
            //        {
            //            //break; // break out the loop
            //            continue; //skip one
            //        };

            //        Console.Write(k + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////nested while loop
            //int i = 9;

            //while (i >= 0)
            //{

            //    int k = i;
            //    while (k >= 0)
            //    {
            //        Console.Write(k + " ");
            //        k--;
            //    }
            //    Console.WriteLine();
            //    i--;
            //}

            ////array
            //int[] grades = { 50, 40, 30, 20 };
            //bool found = false;

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    //Console.WriteLine(grades[i] + " ");
            //    if(grades[i]==30)
            //    {
            //        Console.WriteLine($"We found {grades[i]} at index of {Array.IndexOf(grades, 30)}");
            //        found = true;
            //        break;
            //    }

            //}
            //if (!found)
            //{
            //    Console.WriteLine("Not found");
            //}

            ////array input
            //int size = Convert.ToInt32(Console.In.ReadLine());

            //int[] grades = new int[size];
            //for(int i=0; i< grades.Length; i++)
            //{
            //    grades[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for(int i = 0; i< grades.Length; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}

            ////array sort

            //int[] grades = { 40, 25, 30, 20 };
            //Array.Sort(grades);
            //Array.Reverse(grades);
            //for (int i=0; i< grades.Length; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}

            //int[] grades1 = { 12, 34, 44, 56 };
            //int[] grades2 = { 12, 34, 44, 56 };
            //if(Enumerable.SequenceEqual(grades1, grades2))
            //{
            //    Console.WriteLine("Equal!");

            //}

            ////array multi-dimentional
            //int[,] grades = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            //Console.WriteLine(grades[2, 2]);

            ////array multi-dimentional jagged
            //int[][] grades =
            //{
            //    new int[] { 1, 2,},
            //    new int[] { 3, 4,},
            //    new int[] { 5, 6, 7, 8, 9}
            //};
            //Console.WriteLine(grades[2] [3]);
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.Write(grades[i][j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            ////array 2D
            //int[,] grades =
            //{
            //    { 1, 2, 3, },
            //    { 4, 5, 6, },
            //    { 6, 7, 8, }
            //};

            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++) 
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            ////List
            ////List<int> grades = new List<int>() { 20, 30};
            //var grades = new List<int>() { 20, 30 };
            ////grades.Add(5);
            //grades.Add(40);
            //grades.Insert(1, 5);
            //grades.Remove(5);
            //grades.AddRange(grades);
            //Console.WriteLine(grades.Count);
            //Console.WriteLine(grades[1]);
            //Console.WriteLine(grades[4]);
            //if (grades.Contains(30)) { Console.WriteLine("found"); }
            //if(grades.IndexOf(30) ==1) { Console.WriteLine("true"); }
            //if(grades.LastIndexOf(30) ==4) { Console.WriteLine("last"); }
            ////grades.Clear();
            ////grades = new List<int>();


            ////List compare equal
            //var grades1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //var grades2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //if (grades1.SequenceEqual(grades2)) { Console.WriteLine("Equal!"); }

            //foreach (var grade in grades1) { Console.WriteLine(grade); }
            //Console.WriteLine();
            //for (int i = 0;i <grades2.Count;i++)
            //{
            //    Console.WriteLine(grades2[i]);
            //}

            ////List of list
            //var studentGrades = new List<List<int>>()
            //{
            //    new List<int> { 1, 2, 3 },
            //    new List<int> { 4, 5, 6 },
            //    new List<int> { 7, 8, 9 }
            //};

            //foreach (var student in studentGrades)
            //{
            //    foreach (var studentGrade in student)
            //    {
            //        Console.Write(studentGrade + "\t");
            //    }
            //    Console.WriteLine();
            //}
           
            //var myArr = studentGrades.ToArray();
            //var myArr2 = myArr.ToArray();
            //var myList = myArr.ToList();

            ////jagged array of list
            //var studentGrades = new int[][]
            //{
            //    new int[] { 1, 2, 3 },
            //    new int[] { 4, 5, 6 },
            //    new int[] { 7, 8, 9, 10 }
            //};

            //foreach (var student in studentGrades)
            //{
            //    foreach (var studentGrade in student)
            //    {
            //        Console.Write(studentGrade + "\t");
            //    }
            //    Console.WriteLine();
            //}

            var myProgram = new Program();
            myProgram.doSomething();

        }



        //local variable n hides field n
        public void doSomething()
        {
            var myUser = new User();
            myUser.FirstName = "Caleb";
            myUser.LastName = "Curry";
            var message = myUser.Output(3);
            Console.WriteLine(message);
            Console.WriteLine($"My name is {myUser.FullName}!");
            
            var myUser2 = new User();
            myUser2.FirstName = "Caleb";
            myUser2.LastName = "Curry";
            var users = new List<User>();
            users.Add(myUser);
            users.Add(myUser2);
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }

            Console.WriteLine(myUser.FullName.GetHashCode());
            Console.WriteLine(myUser2.FullName.GetHashCode());

            if (myUser.FullName.GetHashCode() == myUser2.FullName.GetHashCode())
            {
                Console.WriteLine("equal!");
            }

            if (myUser.Equals(myUser2))
            {
                Console.WriteLine("equal equal!");
            }

            var search = new User();
            search.FirstName = "Caleb";
            search.LastName = "Curry";
            if(User.Find(users,search)>= 0)
            Console.WriteLine("Found!");


            Console.WriteLine(User.GetUser(users, search));

            if(User.GetUser(users, search) == null)
            {
                Console.WriteLine($"{search.FullName} not found!");
            };

            // BroCode
            Random random = new Random();
            // js Math.random()
            int num = random.Next(1, 7);
            Console.WriteLine(num);


            //enum
            Console.WriteLine(Planets.Pluto + " is #" + (int)Planets.Pluto);

            string myString = @"Go to your c:\ drive";
            string myString2 = string.Format("{0:C1}", 123.45);
            string myString3 = string.Format("{0:N}", 1234567890);
            string myString4 = string.Format("Percent: {0:P}", .1234);
            string myString5 = string.Format("Phone Number: {0:(###) ###-####}", 4142986166);
            
            Console.WriteLine(myString);
            Console.WriteLine();
            Console.WriteLine(myString2);
            Console.WriteLine( );
            Console.WriteLine(myString3);
            Console.WriteLine();
            Console.WriteLine(myString4);
            Console.WriteLine();
            Console.WriteLine(myString5);
            Console.WriteLine();

            string name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = GetVolume(name, radius);
            // decimal
            decimal volDecimal = (decimal)volume;
            Console.WriteLine(volume); //4 decimals
            Console.WriteLine(volDecimal.ToString("F")); // 2 decimals
            Console.WriteLine(volDecimal.ToString("#.##")); // 2 decimals
            Console.WriteLine(volDecimal.ToString("C")); // 2 decimals $
            //string.Format
            Console.WriteLine(String.Format("{0:C}", volDecimal)); // 2 decimals $

            Console.WriteLine($"Volume for {name} is { String.Format("{0:0.00}", volume)}");


            // generics

            int[] num1 = { 0, 1, 2 };
            string[] word = { "zero", "one", "two" };

            GetIt(num1);
            GetIt(word);
            Console.WriteLine();


            //multi thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Threas";
            Console.WriteLine(mainThread.Name);

            ////Thread thread1 = new Thread(CountDown);
            ////Thread thread2 = new Thread(CountUp);
            //Thread thread1 = new Thread(() => CountDown("Timer 1"));
            //Thread thread2 = new Thread(() => CountUp("Timer 2"));
            //thread1.Start();
            //thread2.Start();
            CountDown("Timer 1");
            CountUp("Timer 2");

          
        }


        private static double GetVolume(string name, int radius)
        {
            return (4.0/3.0) * Math.PI * Math.Pow(radius, 3);
        }



        private static void GetIt<T>(T[] it)
        {
            foreach (T i in it)
            {
                Console.Write(i + " ");
            }
        } 

        private static void CountDown(string name)
        {
            for (int i = 10; i >=0; i--)
            {
                Console.WriteLine($"{name}: {i} seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #1 is complete!");
        }

        private static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{name}: {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!!");
        }

    }

}
