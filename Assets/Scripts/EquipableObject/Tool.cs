using UnityEngine;
using System.Collections;
using System;

public class Tool : EquipableObject {

	protected override void Start () {
        base.Start( );
        weight = 0.0f;
	}

    public bool Equals (Tool cmpTool) {
        return String.Equals( cmpTool.objName, objName );
    }
}
