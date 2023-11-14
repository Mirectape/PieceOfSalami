using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

}
