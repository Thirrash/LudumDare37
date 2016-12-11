using UnityEngine;
using System.Collections;
using System;

public class Tool : EquipableObject {

	protected override void Start () {
        base.Start( );
        weight = 0.0f;
        tag = "Tool";
	}

    public bool Equals (Tool cmpTool) {
        return String.Equals( cmpTool.objName, objName );
    }

    public void CopyFrom(Tool tool) {
        weight = tool.weight;
        currObjects = tool.currObjects;
        objName = tool.objName;
    }
}
