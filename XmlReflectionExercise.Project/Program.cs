﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XmlReflectionExercise.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arrange
            XMLReaderClass XObject = new XMLReaderClass();
            //Act
            var xmlcont = XObject.Read("C:\\Users\\joseph.bannert\\Desktop\\XmlReflectionExercise\\employee.xml", "hire-date");
            foreach (var item in xmlcont)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
            */
            foreach (var item in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

        }
    }
}
