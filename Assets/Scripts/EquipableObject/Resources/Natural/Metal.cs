using UnityEngine;
using System.Collections;

public class Metal : Resource 
{
    protected override void Start () {
        base.Start( );
        objName = "Metal";
        weight = 0.5f;
    }
}
