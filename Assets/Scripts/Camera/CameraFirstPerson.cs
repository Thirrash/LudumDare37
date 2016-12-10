using UnityEngine;
using System.Collections;

public class CameraFirstPerson : CameraBase
{
    float targetRotationX;
    float targetRotationY;

    protected override void Start( ) {
        base.Start( );
        targetRotationX = transform.rotation.eulerAngles.x;
        targetRotationY = player.transform.rotation.eulerAngles.y;
        Cursor.lockState = CursorLockMode.Locked;
    }

    protected override void OnDestroy( ) {
        base.OnDestroy( );
    }

    protected override void Update( ) {
        base.Update( );
        player.transform.rotation = Quaternion.Lerp( player.transform.rotation,
                                                     Quaternion.Euler( new Vector3( 0.0f,
                                                                                  targetRotationY,
                                                                                  0.0f) ),
                                                     player.stats.cameraSpeed );
        transform.rotation = Quaternion.Lerp( transform.rotation,
                                              Quaternion.Euler( new Vector3( targetRotationX,
                                                                           targetRotationY,
                                                                           0.0f ) ),
                                              player.stats.cameraSpeed );
    }

    protected override void RotateUp( ) {
        targetRotationX += player.stats.cameraSpeed;
    }

    protected override void RotateDown( ) {
        targetRotationX -= player.stats.cameraSpeed;
    }

    protected override void RotateLeft( ) {
        targetRotationY -= player.stats.cameraSpeed;
    }

    protected override void RotateRight( ) {
        targetRotationY += player.stats.cameraSpeed;
    }
}
