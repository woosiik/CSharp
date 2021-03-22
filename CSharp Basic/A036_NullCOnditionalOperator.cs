using System;
namespace Basic
{
    class A035_PassingArrayAndObject
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0}", arr[0]);
            Change(arr);
            Console.WriteLine("Main() after: arr[0] = {0}", arr[0]);
            Student s1 = new Student();
            s1.name = "Alpha";
            Console.WriteLine("Main() before: " + s1.name);
            Change(s1);
            Console.WriteLine("Main() after: " + s1.name);
        }
        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }
        private static void Change(Student s1)
        {
            s1.name = "Beta";
        }
    }
    class Student
    {
        public string name;
    }
}using System;
namespace Basic
{
    class A036_NullCOnditionalOperator
    {
        static void Main(string[] args)
        {
            string animal = null;
            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물이름: ");
            } while ((animal = Console.ReadLine()) != "");
        }
        private static void LongNameAnimal(string animal)
        {
            if (animal.Length >= 4)
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}