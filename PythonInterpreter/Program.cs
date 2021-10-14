using System;
using System.Linq;
using ArgParser;

namespace PythonInterpreter
{
    internal static class Program
    {
        private static string temp(string[] args)
        {
            string res = args.Aggregate("[", (current, s) => current + (s + ", "));
            res += "]";
            return res;
        }
        
        public static void Main(string[] args)
        {
            ArgumentParser parser = new ArgumentParser();
            
            parser.Display();
            
            Console.WriteLine(temp(args));
            
            Console.WriteLine("Hello World!");
        }
    }
}