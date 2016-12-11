using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Data : EventTrigger {
    public EquipableObject resourse;
    public Text text;
    public Text textInstance;
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

    public override void OnPointerEnter(PointerEventData data) {
        textInstance.text = resourse.objName + ": " + resourse.currObjects;
    }

    public override void OnPointerExit(PointerEventData data) {
        textInstance.text = "";
    }
}
