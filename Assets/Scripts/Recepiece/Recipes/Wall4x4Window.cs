using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Wall4x4Window : Recepiece
{
    public Wall4x4Window(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wall4x4", 1));
        ListMaterial.Add(new Globals.Material("Glass", 2));
        ListMaterial.Add(new Globals.Material("Plastic", 2));
        ListTool.Add(new Globals.Material("Hammer"));
        ListTool.Add(new Globals.Material("Saw"));
        image = Resources.Load<Sprite>("Image/Wall/Wall4x4Window");
        objName = "Wall4x4Window";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 6.4f;
        rec.prefab = Resources.Load("Wall/Wall4x4Window") as GameObject;
        rec.currObjects = 1;
        rec.avatar = image;
        createObject = rec;
    }
}