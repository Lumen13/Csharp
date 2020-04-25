using System;
using System.Security.Cryptography.X509Certificates;

namespace _4
{
    public enum Some
    {
        TestValue, TestValue1, TestValue2
    }
    class NewClass
    {
        private int Number2 { get; set; }
        private void PrivateFunc()
        {
            
        }
        public int Number = 0;
        public string Word = "Hello";
        public Some some = Some.TestValue1;
    }
    class Program
    {

        static void Func(object qwe)
        {
            var asdf = qwe as NewClass;
        }
        static void Main(string[] args)
        {
            NewClass newClass = new NewClass();
            var test = (object)newClass;
            Func(test);
        }
    }
}
