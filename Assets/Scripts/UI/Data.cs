using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Data : MonoBehaviour {
    public EquipableObject resourse;
    public Text text;
    Button but;

	void Start () {
        if( resourse.tag == "Placable" ) {
            Debug.Log( resourse.objName );
            but = gameObject.AddComponent<Button>( );
            but.onClick.AddListener( ( ) => ChangePlacable( ) );
        }
	}
	
	void Update () {
        text.text = resourse.currObjects.ToString();
	}

    void ChangePlacable( ) {
        Player.instance.controller.ReplacePlacable( resourse as PlacableObject );
    }
}
