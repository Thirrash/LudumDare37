using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Chair : Recepiece
{
    public Chair(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wood", 2));
        ListMaterial.Add(new Globals.Material("Nail", 1));
        ListTool.Add(new Globals.Material("Hammer"));
        image = Resources.Load<Sprite>("Image/Items/Chair");
        objName = "Chair";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Items/Chair") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}

