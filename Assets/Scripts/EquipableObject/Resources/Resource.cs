using UnityEngine;
using System.Collections;

public class Resource : EquipableObject 
{
    protected override void Start() 
    {
        base.Start( );
        tag = "Resource";
	}

    public void CopyFrom(Resource res) {
        weight = res.weight;
        currObjects = 1;
        objName = res.objName;
        tag = res.tag;
        avatar = res.avatar;
    }
}
