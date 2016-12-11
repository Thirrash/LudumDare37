using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class SmallLamp : Recepiece
{
    public SmallLamp(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Glass", 2));
        ListMaterial.Add(new Globals.Material("Fuel", 1));
        ListTool.Add(new Globals.Material("Screwdriver"));
        ListTool.Add(new Globals.Material("Bucket"));
        image = Resources.Load("Image/Items/SmallLamp") as Image;
        objName = "SmallLamp";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Items/SmallLamp") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}