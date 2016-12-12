using UnityEngine;
using System.Collections;

public class Close : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void CloseB()
    {
        gameObject.SetActive(false);
    }
}
