using UnityEngine;
using System.Collections.Generic;

public class Book : MonoBehaviour {
    List<Recepiece> recepiece = new List<Recepiece>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public List<Recepiece> GetList()
    {
        return recepiece;
    }
}
