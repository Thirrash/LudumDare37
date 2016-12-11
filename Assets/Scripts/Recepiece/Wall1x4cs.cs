using UnityEngine;
using System.Collections.Generic;
using System.Linq;


    class Wall1x4cs : Recepiece
{
    public Wall1x4cs(GameObject ga)
    {
        ListMaterial.Add(new Globals.Material("Wood", 5));
        ListTool.Add( new Globals.Material( "Saw" ) );
        image = null;
        objName = "Wall 1 x 4";
        PlacableObject rec = ga.AddComponent<PlacableObject>();
        rec.length = 1;
        rec.width = 1;
        rec.objName = objName;
        rec.weight = 1.6f;
        rec.prefab = Resources.Load("Wall/Wall1x4") as GameObject;
        createObject = rec;
    }
}

