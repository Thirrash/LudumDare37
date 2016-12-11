using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RecepiceButtton : MonoBehaviour {
    public Recepiece rec;
    private Button _button;
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
        Debug.Log("Click");
        matEq.Add( rec.createObject );

        List<Resource> matList = matEq.GetList( );
        foreach( Globals.Material m in rec.ListMaterial ) {
            matEq.GetResourceByName( m.name ).currObjects -= m.howMany;
        }
    }
}
