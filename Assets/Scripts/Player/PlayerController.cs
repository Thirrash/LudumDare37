using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    Player player;
    PlayerStatistics stats;
    public float maxWeightChangePerMeterAndKilo = 0.0f;
    Ray ray;
    RaycastHit rayHit;
    Collider colliderOnMouse;

    void Start( ) {
        player = Player.instance;
        stats = GetComponent<PlayerStatistics>( );
        EventManager.StartListening( EventTypes.playerForward, MoveForward );
        EventManager.StartListening( EventTypes.playerBackwards,
                                     MoveBackwards );
        EventManager.StartListening( EventTypes.playerLeft, MoveLeft );
        EventManager.StartListening( EventTypes.playerRight, MoveRight );
        EventManager.StartListening( EventTypes.playerPick, Pick );
    }

    void OnDestroy( ) {
        EventManager.StopListening( EventTypes.playerForward, MoveForward );
        EventManager.StopListening( EventTypes.playerBackwards, MoveBackwards );
        EventManager.StopListening( EventTypes.playerLeft, MoveLeft );
        EventManager.StopListening( EventTypes.playerRight, MoveRight );
        EventManager.StopListening( EventTypes.playerPick, Pick );
    }

    void Update( ) {
        ray = Camera.main.ScreenPointToRay( Input.mousePosition );
        if( Physics.Raycast( ray, out rayHit ) ) {
            colliderOnMouse = rayHit.collider;
            Debug.Log( colliderOnMouse.gameObject.name );
        }
    }

    void MoveForward( ) {
        transform.Translate( transform.forward * stats.movementVerticalSpeed,
                             Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementVerticalSpeed * stats.currWeight;
    }

    void MoveBackwards( ) {
        transform.Translate( -transform.forward * stats.movementVerticalSpeed,
                             Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementVerticalSpeed * stats.currWeight;
    }

    void MoveLeft( ) {
        transform.Translate( -transform.right * stats.movementHorizontalSpeed,
                             Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementHorizontalSpeed * stats.currWeight;
    }

    void MoveRight( ) {
        transform.Translate( transform.right * stats.movementHorizontalSpeed,
                             Space.World );
        stats.maxWeight += maxWeightChangePerMeterAndKilo * stats.movementHorizontalSpeed * stats.currWeight;
    }

    void Pick( ) {
        float distanceBetween = Vector3.Distance( transform.position,
                                                 colliderOnMouse.gameObject.transform.position);
        if( distanceBetween <= stats.pickDistance ) {
            Resource[] resources = colliderOnMouse.gameObject.GetComponents<Resource>( );
            Tool[] tools = colliderOnMouse.gameObject.GetComponents<Tool>( );

            foreach( Resource r in resources ) {
                player.matEq.Add( r );
                r.DecreaseObjectQuantity( 1 );
            }

            foreach( Tool t in tools ) {
                player.toolEq.Add( t );
                t.DecreaseObjectQuantity( 1 );
            }
        }
    }
}
