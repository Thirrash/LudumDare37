using UnityEngine;
using System.Collections;

public class CameraBase : MonoBehaviour {
    protected Player player;

    protected virtual void Start( ) {
        player = Player.instance;
        EventManager.StartListening( EventTypes.cameraUp, RotateUp );
        EventManager.StartListening( EventTypes.cameraDown, RotateDown );
        EventManager.StartListening( EventTypes.cameraLeft, RotateLeft );
        EventManager.StartListening( EventTypes.cameraRight, RotateRight );
    }

    protected virtual void OnDestroy( ) {
        EventManager.StopListening( EventTypes.cameraUp, RotateUp );
        EventManager.StopListening( EventTypes.cameraDown, RotateDown );
        EventManager.StopListening( EventTypes.cameraLeft, RotateLeft );
        EventManager.StopListening( EventTypes.cameraRight, RotateRight );
    }

    protected virtual void Update( ) {

    }

    protected virtual void RotateUp( ) {

    }

    protected virtual void RotateDown( ) {

    }

    protected virtual void RotateLeft( ) {

    }

    protected virtual void RotateRight( ) {

    }
}
