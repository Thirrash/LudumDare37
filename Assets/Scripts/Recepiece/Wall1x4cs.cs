using System;
using System.Collections.Generic;
using System.Linq;


    class Wall1x4cs : Recepiece
    {
        public Wall1x4cs()
        {
            ListMaterial.Add(new Globals.Material("Wood", 5));
            image = null;
            objName = "Wall 1 x 4";
            createObject = null;
        }
    }

