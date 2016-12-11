using UnityEngine;
using System.Collections;

public class WorkPlace : MonoBehaviour {
    public GameObject player;
    private ToolsEpuipment _Tools;
    private MaterialEquipment _Material;
    private PlayerStatistics _Statistick;
    private Book _book;
	// Use this for initialization
	void Start () {
        _Tools = player.GetComponent<ToolsEpuipment>();
        _Material = player.GetComponent<MaterialEquipment>();
        _Statistick = player.GetComponent<PlayerStatistics>();
        _book = GetComponentInChildren<Book>();
        Debug.Log(_book.GetList());
        Debug.Log(_Material);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
