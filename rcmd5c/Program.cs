using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rcmd5c
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCheck fCheck = new FileCheck();

            Console.WriteLine("MD5 Checksum of: {0}\n{1}\n", args[0], fCheck.GetMD5Checksum(args[0]));
            Console.Read();
        }
    }
}
