﻿using UnityEngine;
using System.Collections.Generic;

public class ToolsEpuipment : MonoBehaviour {

    [SerializeField]
    List<Tool> tools = new List<Tool>();
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SortByName()
    {
        tools.Sort(
            delegate (Tool t1, Tool t2)
            {
                return t1.objName.CompareTo(t2.objName);
            });
    }

    public bool Check(Tool t)
    {
        foreach(Tool list in tools)
        {
            if(list.Equals(t))
            {
                return true;
            }
        }
        return false;
    }
}
