using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task mytask = new Task();
            mytask.printname("install my new progam");


            TaskManager mylist = new TaskManager();
            mylist.AddTask("Delete My Computer icon");
            mylist.AddTask("install my new progam");
            mylist.AddTask("install my new book");
            mylist.AddTask("install my new packag");

            ArrayList list = mylist.GetList();
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            string searchI = "install my new book";

            ArrayList searchR = mylist.search(searchI);

            Console.WriteLine($"Found {searchR.Count} instances of \"{searchI}\":");
            foreach (object item in searchR)
            {
                Console.WriteLine(item);
            }

            mylist.RemoveItemAt(2);

            Console.WriteLine("After deleting an item:");
            foreach (object item in mylist.GetList())
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }

    
}
