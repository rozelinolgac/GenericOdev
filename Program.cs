using System;

namespace GenericOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<string, string> generic = new Generic<string, string>();
            generic.Add("escalator", "yürüyen merdiven");
            generic.Add("elevator", "asansör");
            generic.ToList();
        }
    }
}