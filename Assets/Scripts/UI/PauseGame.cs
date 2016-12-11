using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
    public GameObject Inventory;
    public GameObject Statistic;
    public GameObject Crafting;
	// Use this for initialization
	void Start () {
        EventManager.StartListening( EventTypes.showStats, ActivateStats );
        EventManager.StartListening( EventTypes.showInventory, ActivateInventory );
        EventManager.StartListening( EventTypes.showCrafting, ActivateCrafting );
	}
	
    void OnDestroy( ) {
        EventManager.StopListening( EventTypes.showStats, ActivateStats );
        EventManager.StopListening( EventTypes.showInventory, ActivateInventory );
        EventManager.StopListening( EventTypes.showCrafting, ActivateCrafting );
    }

	// Update is called once per frame
	void Update () {
        if(Statistic.activeSelf || Inventory.activeSelf || Crafting.activeSelf)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        if (!Statistic.activeSelf && !Inventory.activeSelf && !Crafting.activeSelf)
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void ActivateStats( ) {
        Statistic.SetActive( !Statistic.activeSelf );
    }

    void ActivateInventory( ) {
        Inventory.SetActive( !Inventory.activeSelf );
    }

    void ActivateCrafting( ) {
        Crafting.SetActive( !Crafting.activeSelf );
    }
}
