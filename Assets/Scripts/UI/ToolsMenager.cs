using UnityEngine;
using System.Collections.Generic;

public class ToolsMenager : MonoBehaviour {

    public GameObject content;
    public GameObject player;
    public GameObject prefab;
    List<GameObject> createConent = new List<GameObject>();
    private ToolsEpuipment _tool;
    // Use this for initialization
    void Start()
    {
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
        createConent.Add(pol);
    }
}
