using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Wood : Resource
{
    protected override void Start () {
        base.Start( );
        objName = "Wood";
        weight = 0.3f;
        avatar = Resources.Load<Sprite>( "Image/Resources/Wood" );
    }
}
