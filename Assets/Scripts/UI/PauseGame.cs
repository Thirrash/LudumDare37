using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
    public GameObject Inventory;
    public GameObject Statistic;
    public GameObject Crafting;
    public GameObject Workplace;
    Vector3 playerPos;

	void Start () {
        EventManager.StartListening( EventTypes.showStats, ActivateStats );
        EventManager.StartListening( EventTypes.showInventory, ActivateInventory );
        EventManager.StartListening( EventTypes.showCrafting, ActivateCrafting );
        playerPos = Player.instance.gameObject.transform.position;
	}
	
    void OnDestroy( ) {
        EventManager.StopListening( EventTypes.showStats, ActivateStats );
        EventManager.StopListening( EventTypes.showInventory, ActivateInventory );
        EventManager.StopListening( EventTypes.showCrafting, ActivateCrafting );
    }
        
	void Update () {
        if(Statistic.activeSelf || Inventory.activeSelf || Crafting.activeSelf)
        {
            Player.instance.controller.StopListeningInput( );
            Time.timeScale = 0;
            //Player.instance.gameObject.transform.position = playerPos;
            Cursor.lockState = CursorLockMode.None;
        }
        if (!Statistic.activeSelf && !Inventory.activeSelf && !Crafting.activeSelf)
        {
            Player.instance.controller.StartListeningInput( );
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void ActivateStats( ) {
        Statistic.SetActive( !Statistic.activeSelf );
        playerPos = Player.instance.gameObject.transform.position;
    }

    void ActivateInventory( ) {
        Inventory.SetActive( !Inventory.activeSelf );
        playerPos = Player.instance.gameObject.transform.position;
    }

    void ActivateCrafting( ) {
        if( Vector3.Distance( Player.instance.gameObject.transform.position, Workplace.transform.position ) <= Player.instance.stats.pickDistance ) {
            Crafting.SetActive( !Crafting.activeSelf );
        }
        playerPos = Player.instance.gameObject.transform.position;
    }
}
