using UnityEngine;
using System.Collections;

public class Saw : Tool 
{
    protected override void Start () {
        base.Start( );
        objName = "Saw";
        avatar = Resources.Load<Sprite>( "Image/Tools/Saw" );
    }
}
