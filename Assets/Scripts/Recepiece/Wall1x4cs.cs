﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Wall1x4cs : Recepiece
    {
    public Wall1x4cs()
    {
        ListMaterial.Add(new Globals.Material("Wood", 5));
        image = null;
        objName = "Wall 1 x 4";
        createObject
    }
    }

