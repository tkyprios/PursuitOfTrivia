﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pursuit_of_Trivia
{
    internal class Player
    {
        public string Name { get; private set; }
        public Player(string name) 
        { 
            Name = name;
        }
    }
}
