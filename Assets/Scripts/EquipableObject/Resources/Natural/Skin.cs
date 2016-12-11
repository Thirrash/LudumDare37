using UnityEngine;
using System.Collections;

public class Skin : Resource
{
    protected override void Start () {
        base.Start( );
        objName = "Skin";
        weight = 0.15f;
        avatar = Resources.Load<Sprite>( "Image/Resources/Skin" );
    }
}
