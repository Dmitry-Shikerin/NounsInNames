﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Существительные_в_именах_классов_и_объектов
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class PlayerSettings { }
    class GunController { }
    class FollowTarget { }
    class UnitProvider
    {
        public IReadOnlyCollection<Unit> Units { get; private set; }
    }

    class Unit { }
}
