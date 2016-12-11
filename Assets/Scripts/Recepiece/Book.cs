using UnityEngine;
using System.Collections.Generic;

public class Book : MonoBehaviour {
    List<Recepiece> recepiece = new List<Recepiece>();

	void Start () {
        recepiece.Add(new Wall1x4cs(gameObject));
	}
	

	void Update () {
	
	}


    public List<Recepiece> GetList()
    {
        return recepiece;
    }
}
