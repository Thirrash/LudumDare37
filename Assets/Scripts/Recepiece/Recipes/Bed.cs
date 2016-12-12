using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Bed : Recepiece
{
    public Bed(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wood", 3));
        ListMaterial.Add(new Globals.Material("Skin", 1));
        ListTool.Add(new Globals.Material("Hammer"));
        ListTool.Add(new Globals.Material("Knife"));
        image = Resources.Load<Sprite>("Image/Items/Bed");
        objName = "Bed";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 2;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 3.2f;
        rec.prefab = Resources.Load("Items/Bed") as GameObject;
        rec.currObjects = 1;
        rec.avatar = image;
        createObject = rec;
    }
}
