﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NattBatch
{
    internal class App
    {
        internal void Run()
        {
            var nameService = new NameService();
            while (true)
            {
                Console.WriteLine("Ange id:");
                int id = Convert.ToInt32(Console.ReadLine());
                var name = nameService.GetName(id);
                Console.WriteLine(name);

            }
        }
    }
}
