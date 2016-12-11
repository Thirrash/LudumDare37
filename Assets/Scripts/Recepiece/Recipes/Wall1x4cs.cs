using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


    class Wall1x4cs : Recepiece
{
    public Wall1x4cs(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wood", 5));
        ListTool.Add(new Globals.Material("Saw"));
        image = Resources.Load<Sprite>("Image/Wall/Wall1x4");
        objName = "Wall1x4";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Wall/Wall1x4") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}

