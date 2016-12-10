using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Data : MonoBehaviour {
    public EquipableObject resourse;
    public Text text;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        text.text = resourse.currObjects.ToString();
	}
}
