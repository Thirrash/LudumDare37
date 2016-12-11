using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Door : Recepiece
{
    public Door(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wood", 2));
        ListMaterial.Add(new Globals.Material("Metal", 1));
        image = Resources.Load<Sprite>("Image/Items/Door");
        objName = "Door";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Items/Door") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}