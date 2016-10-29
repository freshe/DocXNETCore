﻿using System;
using System.IO;
using Novacode;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var doc = Novacode.DocX.Create(@"MyFile.docx");
            var p = doc.InsertParagraph();
            p.Append("Hello World");
            doc.Save();

        }
    }
}
