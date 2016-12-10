using UnityEngine;
using System.Collections;
using System;

public class Tool : EquipableObject {

	void Start () {
        weight = 0.0f;
        maxObjects = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool Equals (Tool cmpTool) {
        return String.Equals( cmpTool.objName, objName );
    }
}
