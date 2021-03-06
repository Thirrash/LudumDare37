﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ToolsMenager : MonoBehaviour {

    public GameObject content;
    public GameObject player;
    public GameObject prefab;
    public Text text;
    List<GameObject> createConent = new List<GameObject>();
    private ToolsEpuipment _tool;
    // Use this for initialization
    void Start()
    {
        player = Player.instance.gameObject;
        _tool = player.GetComponent<ToolsEpuipment>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Tool r in _tool.GetList())
        {
            if (!Check(r))
            {
                CreateContent(r);
            }
        }

    }
    bool Check(Tool r)
    {
        foreach (GameObject z in createConent)
        {
            if (z.GetComponent<Data>().resourse == r)
            {
                return true;
            }
        }
        return false;
    }
    void CreateContent(Tool r)
    {
        GameObject pol = Instantiate(prefab) as GameObject;
        pol.transform.parent = content.gameObject.transform;
        pol.GetComponent<Data>().resourse = r;
        pol.GetComponent<Data>().textInstance = text;
        createConent.Add(pol);
    }
}
