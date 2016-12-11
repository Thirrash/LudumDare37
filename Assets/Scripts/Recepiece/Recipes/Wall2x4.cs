using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Wall2x4 : Recepiece
{
    public Wall2x4(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wall 1 x 4", 2));
        ListTool.Add(new Globals.Material("Hammer"));
        image = Resources.Load("Image/Wall/Wall2x4") as Image;
        objName = "Wall 2 x 4";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 2;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 3.2f;
        rec.prefab = Resources.Load("Wall/Wall2x4") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}

