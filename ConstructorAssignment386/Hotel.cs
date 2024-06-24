using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment386
{
    class Hotel
    {
        public int id;
        public string name;

        public Hotel() : this(0, "")
        {
        }

        public Hotel(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Hotel(int id) : this(id, "")
        {
        }

        public Hotel(string name) : this(0, name)
        {
        }
    }
    
    
}
