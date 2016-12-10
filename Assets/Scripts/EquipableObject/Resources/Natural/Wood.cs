using UnityEngine;
using System.Collections;

public class Wood : Resource
{
    protected override void Start () {
        base.Start( );
        objName = "Wood";
        weight = 0.3f;
    }
}
