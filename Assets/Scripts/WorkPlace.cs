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
	}
	

	void Update () {
	
	}

    public List<Recepiece> GetList( ) {
        return _book.GetList( );
    }

    public bool CheckIfRecipeCreatable( Recepiece rec ) {
        Recepiece foundRecipe = new Recepiece( );
        foreach( Recepiece r in GetList( ) ) {
            if( rec.objName == r.objName ) {
                foundRecipe.CopyFrom(r);
                break;
            }
        }
        if( foundRecipe.objName == "--def--" ) {
            Debug.Log( "Recipe not found!" );
            return false;
        }

        foreach( Globals.Material m in foundRecipe.ListTool ) {
            Tool tmpTool = _Tools.GetToolByName( m.name );
            if( tmpTool == null ) {
                return false;
            }
            if( m.howMany > tmpTool.currObjects ) {
                return false;
            }
        }

        foreach( Globals.Material m in foundRecipe.ListMaterial ) {
            Resource tmpRes = _Material.GetResourceByName( m.name );
            if( tmpRes == null ) {
                return false;
            }
            if( m.howMany > tmpRes.currObjects ) {
                return false;
            }
        }

        return true;
    }
}
