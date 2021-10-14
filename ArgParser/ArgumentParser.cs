using System;
using System.Reflection;

namespace ArgParser
{
    public class ArgumentParser
    {
        public string Prog { get; set; }
        public ArgumentParser()
        {
            Prog = Assembly.GetCallingAssembly().GetName().Name;
        }

        public void Display()
        {
            Console.WriteLine($"usage: {Prog} ");
        }
    }
}