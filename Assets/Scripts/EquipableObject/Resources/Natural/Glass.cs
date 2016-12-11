using UnityEngine;
using System.Collections;

public class Glass : Resource 
{
	protected override void Start () {
        base.Start( );
        objName = "Glass";
        weight = 0.25f;
        avatar = Resources.Load<Sprite>( "Image/Resources/Glass" );
	}
}
