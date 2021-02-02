using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labirintus
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class MapHandler
    {
        private char[,] map;
        private String mapname;

        MapHandler(String name)
        {
            this.mapname = name;
        }

        public String getName()
        {
            return mapname;
        }

        public char[,] getMap()
        {
            return map;
        }
    }
}
