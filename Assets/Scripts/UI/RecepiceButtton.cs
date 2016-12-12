using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class RecepiceButtton : EventTrigger
{
    public Recepiece rec;
    private Button _button;
    public Text text;
    private Image _image;
    Player player;
    MaterialEquipment matEq;

	void Start () {
        _image = GetComponentInChildren<Image>();
        _image.overrideSprite = rec.image;
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
        Player.instance.stats.skills.generalSkill++;

        List<Resource> matList = matEq.GetList( );
        foreach( Globals.Material m in rec.ListMaterial ) {
            matEq.GetResourceByName( m.name ).currObjects -= Mathf.CeilToInt((float)(m.howMany * Player.instance.stats.skills.generalSkill) / 100.0f);
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
