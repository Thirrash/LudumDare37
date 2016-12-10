using UnityEngine;
using System.Collections;

public class WorkPlace : MonoBehaviour {
    public GameObject player;
    private ToolsEpuipment _Tools;
    private MaterialEquipment _Material;
    private PlayerStatistics _Statistick;
	// Use this for initialization
	void Start () {
        _Tools = player.GetComponent<ToolsEpuipment>();
        _Material = player.GetComponent<MaterialEquipment>();
        _Statistick = player.GetComponent<PlayerStatistics>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
