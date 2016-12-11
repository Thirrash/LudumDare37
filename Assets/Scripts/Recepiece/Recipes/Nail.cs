using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


class Nail : Recepiece
{
    public Nail(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Metal", 3));
        image = Resources.Load("Image/Items/Nail") as Image;
        objName = "Nail";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.5f;
        rec.prefab = Resources.Load("Items/Nail") as GameObject;
        rec.currObjects = 1;
        createObject = rec;
    }
}