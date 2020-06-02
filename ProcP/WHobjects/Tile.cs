﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP.WHobjects
{
    public class Tile
    {
        // ---------------------- Fields -----------------------
        protected Point location;

        // -------------------- Properties ---------------------
        public Point Location { get { return location; } }

        // -------------------- Constructor --------------------

        public Tile(Point location)
        {
            this.location = location;
        }

        public Tile() // Required in sub-classes
        {

        }
    }
}
