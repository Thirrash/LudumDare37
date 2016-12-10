using UnityEngine;
using System.Collections;

public class Plastic : Resource
{
    protected override void Start () {
        base.Start( );
        objName = "Plastic";
        weight = 0.1f;
    }
}
