using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8a
{
    public class Item
    {
        string name;


        // Constructor


        public Item(string name)
        {
            this.name = name;
        }


        public string Name
        {
            get { return name; }
        }
    }

}
