using System;
using System.Collections.Generic;
using System.Linq;

namespace task_at_lesson_11._09
{
    class Program
    {

        public delegate void MathOperation(int a, int b);


        static void Main(string[] args)
        {

            #region LOWER / UPPER CASES

            //bool x = false;
            //string word = Console.ReadLine();

            //foreach (char l in word)

            //{
            //    if (Char.IsUpper(l))
            //    {
            //        x = true;
            //    }
            //}
            //Console.WriteLine(x);


            //string word2 = Console.ReadLine();
            //Console.WriteLine(word2.Equals(word2.ToLower()));

            //string Aa = Console.ReadLine();
            //string bb = Aa.ToLower();
            //Console.WriteLine(bb);

            //string CC = Aa.ToUpper();
            //Console.WriteLine(CC);
            #endregion



            #region DELEGATES 01
            //    MathOperation m1 = new MathOperation(Sum);
            //    //MathOperation m1 = Sum;
            //    m1 += Minus;
            //    m1 += Multiply;

            //    //m1.Invoke(10, 6);

            //    Delegate[] i = m1.GetInvocationList();


            //    foreach (var item in m1.GetInvocationList())
            //    {
            //        Console.WriteLine(item.Method.Name);
            //    }
            //    Console.ReadKey();

            //    m1 -= Minus;
            //    foreach (var item in m1.GetInvocationList())
            //    {
            //        Console.WriteLine(item.Method.Name);
            //    }
            //    Console.ReadKey();

            //    m1 -= Multiply;
            //    foreach (var item in m1.GetInvocationList())
            //    {
            //        Console.WriteLine(item.Method.Name);
            //    }
            //    Console.ReadKey();
            //}

            //public static void Sum(int a, int b)
            //{
            //    Console.WriteLine("Sum Result: " + (a + b));
            //}

            //public static void Minus(int a, int b)
            //{
            //    Console.WriteLine("Minus Result: " + (a - b));
            //}

            //public static void Multiply(int a, int b)
            //{
            //    Console.WriteLine("Multiply Result: " + a * b);
            //}
            #endregion



            #region   DELEGATES 02 ve LAMBDA EXPRESSION
            //    MathOperation m1 = new MathOperation(Sum);

            //    ///Anonymous funtion----METOD YOXDUR-----
            //    MathOperation m2 = delegate (int a, int b)
            //    {
            //        Console.WriteLine("Sum Result: " + (a + b));
            //    };

            //    ///Lambda Expression
            //    MathOperation m3= (int a, int b)=> Console.WriteLine("Sum Result: " + (a + b));
            //}

            //public static void Sum(int a, int b)
            //{
            //    Console.WriteLine("Sum Result: " + (a + b));
            //}
            #endregion



            #region LINQ Methods 01

            //    List<int> number1 = new List<int>() { 12, 28, 49, 33, 52 };

            //    foreach (var item in Num(number1))
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //public static List<int> Num(List<int> number)
            //{
            //    List<int> aaa = new List<int>();

            //    foreach (int item in number)
            //    {
            //        if (item > 15)
            //        {
            //            aaa.Add(item);
            //        }

            //    }
            //    return aaa;
            //}
            #endregion



            #region LINQ Methods 02

            //    List<int> number1 = new List<int>() { 11, 23, 36, 41, 50, 66, 78, 83, 96 };

            //    List<int> number2 = number1.OrderByDescending(x => x).Skip(2).Take(5).ToList();
            //    Console.WriteLine(number2);


            //    Person p1 = new Person(1, "onur", "ibadov", new DateTime(1999, 05, 27));
            //    Person p2 = new Person(2, "ayan", "huseynova", new DateTime(2001, 09, 10));
            //    Person p3 = new Person(3, "ruslan", "ibrahimov", new DateTime(2000, 05, 31));
            //    Person p4 = new Person(4, "fidan", "kerimova", new DateTime(2004, 05, 29));

            //    List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            //    List<string> people1 = people.Select(x => x.Name).ToList();
            //    Console.WriteLine(people1);

            //    List<Person> people2 = people.OrderBy(x => x.BirthDate).ToList();
            //    Console.WriteLine(people2);

            //}
            //public class Person
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public string Surname { get; set; }
            //    public DateTime BirthDate { get; set; }

            //    public Person(int id, string name, string surname, DateTime birhtdate)
            //    {
            //        this.Id = id;
            //        this.Name = name;
            //        this.Surname = surname;
            //        this.BirthDate = birhtdate;
            //    }
            //}
            #endregion
        }
    }
}       
