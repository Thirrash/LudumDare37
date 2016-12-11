using UnityEngine;
using System.Collections.Generic;
using Globals;
using UnityEngine.UI;

public class Recepiece {
    public List<Globals.Material> ListMaterial = new List<Globals.Material>();
    public List<Globals.Material> ListTool = new List<Globals.Material>();
    public Image image;
    public string objName;
    public PlacableObject createObject;
    
    public Recepiece()
    {
        objName = "--def--";
    }

    public PlacableObject Create()
    {
        return createObject;
    }

    public void CopyFrom(Recepiece r) {
        ListMaterial = r.ListMaterial;
        ListTool = r.ListTool;
        image = r.image;
        objName = r.objName;
        createObject = r.createObject;
    }
}
