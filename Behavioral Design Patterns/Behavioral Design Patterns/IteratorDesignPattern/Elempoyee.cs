﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    // Collection Item
    class Elempoyee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Elempoyee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
