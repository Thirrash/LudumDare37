using UnityEngine;
using System.Collections;

public class Resource : EquipableObject 
{
    protected override void Start() 
    {
        base.Start( );
	}

    public void CopyFrom(Resource res) {
        weight = res.weight;
        currObjects = 1;
        objName = res.objName;
    }
}
