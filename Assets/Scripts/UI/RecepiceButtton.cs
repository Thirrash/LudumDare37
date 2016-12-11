﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class RecepiceButtton : EventTrigger
{
    public Recepiece rec;
    private Button _button;
    public Text text;
    Player player;
    MaterialEquipment matEq;

	void Start () {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() => Click());
        GetComponentInChildren<Text>().text = rec.objName;
        player = Player.instance;
        matEq = Player.instance.matEq;
	}
	
	void Update () {
	
	}
    public void Click()
    {
        matEq.Add( rec.createObject );

        List<Resource> matList = matEq.GetList( );
        foreach( Globals.Material m in rec.ListMaterial ) {
            matEq.GetResourceByName( m.name ).currObjects -= m.howMany;
        }
    }
    public override void OnPointerEnter(PointerEventData data)
    {
        text.text = rec.objName + ": " + rec.GetString();
    }

    public override void OnPointerExit(PointerEventData data)
    {
        text.text = "";
    }
}
