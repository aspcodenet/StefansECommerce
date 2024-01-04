using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NattBatch
{
    //  1. I morgon ska vi skapa En WebApp som ska använda vår coola 
    //      nameservice.GetName(id);

    // 2. Så vi skapar en ClassLibrary och lägger koden där!

    // 3. Vi ska också göra så att NameService.GetName() läser från Databas - northwind
    // dvs returnerar produktnamn med det id:t
    // dvs vi behöver ett DBContext

    // 4. Vi scaffoldar Databas



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
