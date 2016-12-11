using UnityEngine;
using System.Collections;

public class Screwdriver : Tool
{
    protected override void Start () {
        base.Start( );
        objName = "Screwdriver";
        avatar = Resources.Load<Sprite>( "Image/Tools/Screwdriver" );
    }
}
