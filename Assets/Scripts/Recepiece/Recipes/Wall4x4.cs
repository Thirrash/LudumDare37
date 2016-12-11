﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Wall4x4 : Recepiece
{
    public Wall4x4(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wall 2 x 4", 2));
        ListMaterial.Add(new Globals.Material("Nail", 3));
        ListTool.Add(new Globals.Material("Hammer"));
        image = Resources.Load("Image/Wall/Wall2x4") as Image;
        objName = "Wall 4 x 4";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 4;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 6.4f;
        rec.prefab = Resources.Load("Wall/Wall4x4") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}