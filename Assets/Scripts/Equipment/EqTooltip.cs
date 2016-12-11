using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EqTooltip : MonoBehaviour 
{
    static Text _textInstance;
    public static Text textInstance {
        get {
            return _textInstance;
        }
        private set {
            _textInstance = value;
        }
    }

    void Start( ) {
        textInstance = GetComponent<Text>( );
    }
}
