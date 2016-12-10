using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (MaterialEquipment) )]
[RequireComponent (typeof (ToolsEpuipment) )]
[RequireComponent (typeof (PlayerController) )]
[RequireComponent (typeof (PlayerStatistics) )]
public class Player : MonoBehaviour
{
    PlayerController controller;
    public PlayerStatistics stats { get; private set; }
    public MaterialEquipment matEq { get; private set; }
    public ToolsEpuipment toolEq { get; private set; }
    public Texture cursor;

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
        matEq = GetComponent<MaterialEquipment>( );
        toolEq = GetComponent<ToolsEpuipment>( );
    }

    void OnGUI( ) {
        GUI.DrawTexture( new Rect( new Vector2( Screen.width / 2 - 20,
                                               Screen.height / 2 - 20),
                                   new Vector2( 40,
                                               40) ),
                         cursor );
    }
}
