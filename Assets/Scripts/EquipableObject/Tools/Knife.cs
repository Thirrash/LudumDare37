using UnityEngine;
using System.Collections;

public class Knife : Tool 
{
    protected override void Start () {
        base.Start( );
        objName = "Knife";
        avatar = Resources.Load<Sprite>( "Image/Tools/Knife" );
    }
}
