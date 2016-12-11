using UnityEngine;
using System.Collections;

public class Fuel : Resource
{
    protected override void Start () {
        base.Start( );
        objName = "Fuel";
        weight = 0.05f;
        avatar = Resources.Load<Sprite>( "Image/Resources/Fuel" );
    }
}