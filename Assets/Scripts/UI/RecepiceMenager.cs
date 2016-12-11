using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class RecepiceMenager : MonoBehaviour {
    List<GameObject> createConent = new List<GameObject>();
    public GameObject workPlaceObject;
    public GameObject prefab;
    public GameObject content;
    public Text text;
    private WorkPlace _workPlace;
    void Start()
    {
        _workPlace = workPlaceObject.GetComponent<WorkPlace>();
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Recepiece r in _workPlace.GetList())
        {
            if (!Check(r))
            {
                CreateContent(r);
            }
        }
        foreach(GameObject b in createConent)
        {
            IsInteracteblrButton(b, _workPlace.CheckIfRecipeCreatable(b.GetComponent<RecepiceButtton>().rec));
        }

    }
    bool Check(Recepiece r)
    {
        foreach (GameObject z in createConent)
        {
            if (z.GetComponent<RecepiceButtton>().rec == r)
            {
                return true;
            }
        }
        return false;
    }
    void CreateContent(Recepiece r)
    {
        GameObject pol = Instantiate(prefab) as GameObject;
        pol.transform.parent = content.gameObject.transform;
        pol.GetComponent<RecepiceButtton>().rec = r;
        pol.GetComponent<RecepiceButtton>().text = text;
        createConent.Add(pol);
    }
    void IsInteracteblrButton(GameObject ob, bool t)
    {
        ob.GetComponent<Button>().interactable = t;
    }
}
