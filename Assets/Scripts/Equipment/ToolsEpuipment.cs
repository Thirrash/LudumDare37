using UnityEngine;
using System.Collections.Generic;
using System;

public class ToolsEpuipment : MonoBehaviour {

    [SerializeField] List<Tool> tools = new List<Tool>();
    GameObject toolsObj;

    void Start () {
        toolsObj = new GameObject( "Tools" );
        toolsObj.transform.parent = gameObject.transform;
	}
	
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

    public List<Tool> GetList()
    {
        return tools;
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
    public void Add(Tool t)
    {
        Tool newT = toolsObj.AddComponent<Tool>( );
        newT.CopyFrom( t );
        tools.Add(t);
    }
}
