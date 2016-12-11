using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorkPlace : MonoBehaviour {
    private GameObject player;
    private ToolsEpuipment _Tools;
    private MaterialEquipment _Material;
    private PlayerStatistics _Statistick;
    private Book _book;

	void Start () {
        player = Player.instance.gameObject;
        _Tools = player.GetComponent<ToolsEpuipment>();
        _Material = player.GetComponent<MaterialEquipment>();
        _Statistick = player.GetComponent<PlayerStatistics>();
        _book = GetComponentInChildren<Book>();
        Debug.Log(_book.GetList());
        Debug.Log(_Material);
	}
	

	void Update () {
	
	}

    public List<Recepiece> GetList( ) {
        return _book.GetList( );
    }

    public bool CheckIfRecipeCreatable( Recepiece rec ) {
        return false;
        /*
        bool retValue = false;
        Recepiece foundRecipe;
        foreach( Recepiece r in GetList( ) ) {
            if( rec.objName == r.objName ) {
                foundRecipe = r;
                break;
            }
        }
        if( foundRecipe == null ) {
            Debug.Log( "Recipe not found!" );
            return false;
        }

        foreach( Globals.Material m in foundRecipe.ListMaterial ) {
            //m.
        }

        return false;
        */
    }
}
