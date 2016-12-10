using UnityEngine;
using System.Collections;

[RequireComponent (typeof (MaterialEquipment) )]
[RequireComponent (typeof (ToolsEpuipment) )]
[RequireComponent (typeof (PlayerController) )]
[RequireComponent (typeof (PlayerStatistics) )]
public class Player : MonoBehaviour
{
    PlayerController controller;
    public PlayerStatistics stats { get; private set; }

    static Player _instance;
    public static Player instance {
        get {
            return _instance;
        }
        private set {
            _instance = value;
        }
    }

    void Start( ) {
        instance = this;
        controller = GetComponent<PlayerController>( );
        stats = GetComponent<PlayerStatistics>( );
    }
}
