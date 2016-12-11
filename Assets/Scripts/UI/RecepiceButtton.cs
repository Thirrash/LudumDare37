using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RecepiceButtton : MonoBehaviour {
    public Recepiece rec;
    private Button _button;
	// Use this for initialization
	void Start () {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Click);
        GetComponentInChildren<Text>().text = rec.objName;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Click()
    {
        Debug.Log("Click");
    }
}
