using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ToDoApp
{
    class TaskManager
    {
        private ArrayList list;
        public TaskManager()
        {
            list = new ArrayList();
        }

        public void AddTask(string name)
        {
            list.Add(name);
        }
        public ArrayList GetList()
        {
            return list;
        }
        public ArrayList search(string names)
        {
            ArrayList results = new ArrayList();
            foreach (string i in list)
            {
                if (i.Equals(names))
                {
                    results.Add(i);
                }
            }
            return results;
        }

        public void RemoveItemAt(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    


}

}

