using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    PlayerStatistics stats;
    public float maxWeightChangePerMeterAndKilo = 0.0f;

	void Start () {
        stats = GetComponent<PlayerStatistics>( );
        EventManager.StartListening( EventTypes.playerForward, MoveForward );
        EventManager.StartListening( EventTypes.playerBackwards, MoveBackwards );
        EventManager.StartListening( EventTypes.playerLeft, MoveLeft );
        EventManager.StartListening( EventTypes.playerRight, MoveRight);
        EventManager.StartListening( EventTypes.playerPick, Pick );
	}

    void OnDestroy( ) {
        EventManager.StopListening( EventTypes.playerForward, MoveForward );
        EventManager.StopListening( EventTypes.playerBackwards, MoveBackwards );
        EventManager.StopListening( EventTypes.playerLeft, MoveLeft );
        EventManager.StopListening( EventTypes.playerRight, MoveRight);
    }
	
    void MoveForward( ) {
        transform.Translate( transform.forward * stats.movementVerticalSpeed, Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementVerticalSpeed * stats.currWeight;
    }

    void MoveBackwards( ) {
        transform.Translate( -transform.forward * stats.movementVerticalSpeed, Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementVerticalSpeed * stats.currWeight;
    }

    void MoveLeft( ) {
        transform.Translate( -transform.right * stats.movementHorizontalSpeed, Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementHorizontalSpeed * stats.currWeight;
    }

    void MoveRight( ) {
        transform.Translate( transform.right * stats.movementHorizontalSpeed, Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementHorizontalSpeed * stats.currWeight;
    }

    void Pick( ) {

    }
}
