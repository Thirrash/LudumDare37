using UnityEngine;
using System.Collections.Generic;
using Globals;
using UnityEngine.UI;

public class Recepiece {
    public List<Globals.Material> ListMaterial = new List<Globals.Material>();
    public Image image;
    public string objName;
    public PlacableObject createObject;
    
    public Recepiece()
    {

    }

    public PlacableObject Create()
    {
        return createObject;
    }
}
