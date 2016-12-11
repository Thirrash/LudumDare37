using UnityEngine;
using System.Collections;

public class Bucket : Tool 
{
	protected override void Start () {
        base.Start( );
        objName = "Bucket";
        avatar = Resources.Load<Sprite>( "Image/Tools/Bucket" );
	}
}
