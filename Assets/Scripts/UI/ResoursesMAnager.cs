using UnityEngine;
using System.Collections.Generic;

public class ResoursesMAnager : MonoBehaviour {
    public GameObject content;
    public GameObject player;
    public GameObject prefab;
    List<GameObject> createConent = new List<GameObject>();
    private MaterialEquipment _material;
	// Use this for initialization
	void Start () {
        _material = player.GetComponent<MaterialEquipment>();
	}
	
	// Update is called once per frame
	void Update () {
        foreach(Resource r in _material.GetList())
        {
            if(!Check(r))
            {
                CreateContent(r);
            }
        }
	
	}
    bool Check(Resource r)
    {
        foreach (GameObject z in createConent)
        {
            if(z.GetComponent<Data>().resourse == r)
            {
                return true;
            }
        }
        return false;
     }
    void CreateContent(Resource r)
    {
        GameObject pol = Instantiate(prefab) as GameObject;
        pol.transform.parent = content.gameObject.transform;
        pol.GetComponent<Data>().resourse = r;
        createConent.Add(pol);
    }
}
