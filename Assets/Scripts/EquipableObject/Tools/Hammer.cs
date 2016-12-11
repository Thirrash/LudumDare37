using UnityEngine;
using System.Collections;

public class Hammer : Tool 
{
    protected override void Start () {
        base.Start( );
        objName = "Hammer";
        avatar = Resources.Load<Sprite>( "Image/Tools/Hammer" );
    }
}
