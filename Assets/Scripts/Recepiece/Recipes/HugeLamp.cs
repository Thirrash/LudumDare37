using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class HugeLamp : Recepiece
{
    public HugeLamp(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("SmallLamp", 1));
        ListMaterial.Add(new Globals.Material("Metal", 1));
        ListMaterial.Add(new Globals.Material("Glass", 2));
        ListMaterial.Add(new Globals.Material("Fuel", 2));
        ListTool.Add(new Globals.Material("Screwdriver"));
        ListTool.Add(new Globals.Material("Bucket"));
        image = Resources.Load("Image/Items/HugeLamp") as Image;
        objName = "HugeLamp";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Items/HugeLamp") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}