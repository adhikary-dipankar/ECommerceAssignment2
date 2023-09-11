//using System;
//using System.Collections;

//namespace Prj1Day19Col
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BitArray myBitArr1 = new BitArray(4);
//            BitArray myBitArr2 = new BitArray(4);
//            myBitArr1[0] = false;
//            myBitArr1[1] = false;
//            myBitArr1[2] = true;
//            myBitArr1[3] = true;
//            myBitArr2[0] = false;
//            myBitArr2[2] = false;
//            myBitArr2[1] = true;
//            myBitArr2[3] = true;
//            PrintValues("\n\nBA1 : ", myBitArr1);
//            PrintValues("\n\nBA2 : ", myBitArr2);
//            PrintValues("\n\nOr : BA1.Or(BA2) : ", myBitArr1.Or(myBitArr2));
//            Console.WriteLine("\n");
//        }
//        public static void PrintValues(string s, IEnumerable myList)
//        {
//            Console.WriteLine(s);
//            foreach (Object obj in myList)
//            {
//                Console.Write(obj + "\t");
//            }
//        }
//    }
//}


Ask the user 4 (true/false) questions and compare the answers that user enters with the actual answers

to calculate the marks. Use BitArray to store user's and actual answers.

Q1: Collection namespace has ICollection

interface(T/F):

Q2: An IList in C# represents the class List in other

Languages(T/F): Q3: An Array and any collection is interchangeable

object Types (T/F): Q4: Collection is a part of BCL in .Net Framework

(T/F):

BitArray actual-new BitArray(4).

actual[0]=true, actual[1] = fa BitArray actual new BitArray(4);

actual[0]= true; actual[1]= false; actual[2] = true;



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<Person> generalQueue = new Queue<Person>();
        Queue<Person> seniorCitizenQueue = new Queue<Person>();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter the name of Person {i}: ");
            string name = Console.ReadLine();
            Console.Write($"Enter the age of Person {i}: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(name, age);

            if (age >= 60)
            {
                seniorCitizenQueue.Enqueue(person);
                Console.WriteLine($"{name} added to the Senior Citizen Queue.");
            }
            else
            {
                generalQueue.Enqueue(person);
                Console.WriteLine($"{name} added to the General Queue.");
            }
        }

        Console.WriteLine("\nProcessing Ticket Counter Queue:");

        while (seniorCitizenQueue.Count > 0)
        {
            Console.WriteLine($"Processing {seniorCitizenQueue.Dequeue()}");
            if (generalQueue.Count >= 2)
            {
                Console.WriteLine($"Processing {generalQueue.Dequeue()}");
                Console.WriteLine($"Processing {generalQueue.Dequeue()}");
            }
            else if (generalQueue.Count == 1)
            {
                Console.WriteLine($"Processing {generalQueue.Dequeue()}");
                Console.WriteLine("No more people in the General Queue.");
            }
        }

        while (generalQueue.Count > 0)
        {
            Console.WriteLine($"Processing {generalQueue.Dequeue()}");
        }
    }
}

class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} (Age: {Age})";
    }
}
