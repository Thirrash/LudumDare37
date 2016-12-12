using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Drawer : Recepiece
{
    public Drawer(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wood", 2));
        ListMaterial.Add(new Globals.Material("Metal", 1));
        ListMaterial.Add(new Globals.Material("Metal", 1));
        ListMaterial.Add(new Globals.Material("Nail", 1));
        ListTool.Add(new Globals.Material("Screwdriver"));
        ListTool.Add(new Globals.Material("Hammer"));
        ListTool.Add(new Globals.Material("Knife"));
        image = Resources.Load<Sprite>("Image/Items/Drawer");
        objName = "Drawer";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Items/Drawer") as GameObject;
        rec.currObjects = 1;
        rec.avatar = image;
        createObject = rec;
    }
}