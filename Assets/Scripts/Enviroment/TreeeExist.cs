using UnityEngine;
using System.Collections;

public class TreeeExist : MonoBehaviour {
    private GameObject _tree;
    public bool existe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(_tree != null)
        {
            existe = false;
        }
	}
    public void setTree(GameObject t)
    {
        _tree = t;
        existe = true;
    }
}
