using System;
namespace Shape
{
    public class Rectangle
    {
        public int height;
        public int width;
        override public string ToString()
        {
            return string.Format("Width: {0}, Height: {1}", width, height);
        }
    }
}
using System;
using Shape;
namespace NamespaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 10;
            rect.height = 20;
            Console.WriteLine("rect : " + rect);
        }
    }
}