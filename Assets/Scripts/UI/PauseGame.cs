using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
    public GameObject Inventory;
    public GameObject Statistic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Statistic.activeSelf || Inventory.activeSelf)
        {
            Time.timeScale = 0;
        }
        if (!Statistic.activeSelf && !Inventory.activeSelf)
        {
            Time.timeScale = 1;
        }
    }
}
