using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
    public GameObject Inventory;
    public GameObject Statistic;
	// Use this for initialization
	void Start () {
        EventManager.StartListening( EventTypes.showStats, ActivateStats );
        EventManager.StartListening( EventTypes.showInventory, ActivateInventory );
	}
	
    void OnDestroy( ) {
        EventManager.StopListening( EventTypes.showStats, ActivateStats );
        EventManager.StopListening( EventTypes.showInventory, ActivateInventory );
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

    void ActivateStats( ) {
        Statistic.SetActive( !Statistic.activeSelf );
    }

    void ActivateInventory( ) {
        Inventory.SetActive( !Inventory.activeSelf );
    }
}
