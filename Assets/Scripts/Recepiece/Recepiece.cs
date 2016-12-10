using UnityEngine;
using System.Collections.Generic;
using Globals;
using UnityEngine.UI;

public class Recepiece {
    public List<Globals.Material> ListMaterial = new List<Globals.Material>();
    public Image image;
    public string objName;
    public  createObject;
    
    public Recepiece()
    {

    }

    public GameObject Create()
    {
        return createObject;
    }
}
