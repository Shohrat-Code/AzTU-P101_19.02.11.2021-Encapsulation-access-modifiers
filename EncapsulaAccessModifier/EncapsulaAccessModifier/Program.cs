using System;

namespace EncapsulaAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //string no = "165450";
            //Console.WriteLine(no.PadLeft(10, '0'));
            //int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5, 3};
            ////int[] arr = new int[] { 3, 3, 3, 4, 5, 7, 7, 8 };
            //Console.WriteLine(CountDuplicates(arr));

            //Student stu1 = new Student();

            //Person person2 = new Person();
            //Person person1 = new Person();
            //person1.Name = "Rasim";
            //person1.Score = 550;

            //Console.WriteLine(person1.Score);

            Car car1 = new Car("Audi", "RS7", "Black", 260, 5);
            Console.WriteLine(car1.Brand); 
        }

        //static int CountDuplicates(int[] arr)
        //{
        //    int count = 0, temp = 0;
        //    Array.Sort(arr);
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if(arr[i] == arr[i-1])
        //        {
        //            temp++;
        //        } 
        //        else
        //        {
        //            Console.WriteLine($"Temp: {temp}");
        //            if(temp > 0)
        //            {
        //                count += temp + 1;
        //                temp = 0;
        //            }
        //        }
        //    }
        //    return count;
        //}
    }
}
