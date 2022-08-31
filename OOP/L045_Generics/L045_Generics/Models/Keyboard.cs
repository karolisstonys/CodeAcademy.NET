﻿using L045_Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L045_Generics.Models
{
    public class Keyboard : ITool
    {
        public int Id { get; set; }
        public string Button { get; set; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("This is a keyboard which is used for typing things into the computer.");
        }
    }
}
