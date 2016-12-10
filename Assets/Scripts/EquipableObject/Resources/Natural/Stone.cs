using UnityEngine;
using System.Collections;

public class Stone : Resource
{
    protected override void Start () {
        base.Start( );
        objName = "Stone";
        weight = 0.4f;
    }
}
