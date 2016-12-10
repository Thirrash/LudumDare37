using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

using Globals;
public class PlayerController : MonoBehaviour
{
    public Text tooltipText;
    Player player;
    PlayerStatistics stats;
    public float maxWeightChangePerMeterAndKilo = 0.0f;
    Ray ray;
    RaycastHit rayHit;
    public Collider colliderOnMouse;
    float timeFromLastJump = 0.0f;
    bool isAbleToJump = true;
    string lastHarvestableName;
    bool isTooltipToBeRefreshed = false;

    void Start( ) {
        player = Player.instance;
        stats = GetComponent<PlayerStatistics>( );
        lastHarvestableName = "X";
        EventManager.StartListening( EventTypes.playerForward, MoveForward );
        EventManager.StartListening( EventTypes.playerBackwards,
                                     MoveBackwards );
        EventManager.StartListening( EventTypes.playerLeft, MoveLeft );
        EventManager.StartListening( EventTypes.playerRight, MoveRight );
        EventManager.StartListening( EventTypes.playerJump, Jump );
        EventManager.StartListening( EventTypes.playerPick, Pick );
    }

    void OnDestroy( ) {
        EventManager.StopListening( EventTypes.playerForward, MoveForward );
        EventManager.StopListening( EventTypes.playerBackwards, MoveBackwards );
        EventManager.StopListening( EventTypes.playerLeft, MoveLeft );
        EventManager.StopListening( EventTypes.playerRight, MoveRight );
        EventManager.StopListening( EventTypes.playerJump, Jump );
        EventManager.StopListening( EventTypes.playerPick, Pick );
    }

    void Update( ) {
        CheckOnMouse( );
    }

    void FixedUpdate( ) {
        timeFromLastJump += Time.deltaTime;
        if( timeFromLastJump >= stats.timeBetweenJumps ) {
            isAbleToJump = true;
        }
    }

    void CheckOnMouse( ) {
        ray = Camera.main.ScreenPointToRay( Input.mousePosition );
        if( Physics.Raycast( ray, out rayHit ) ) {
            colliderOnMouse = rayHit.collider;
        }
        if( colliderOnMouse != null ) {
            if( colliderOnMouse.gameObject.tag == Tags.Harvestable ) {
                string currHarvestableName = colliderOnMouse.gameObject.name;
                if( String.Equals( currHarvestableName, lastHarvestableName ) && !isTooltipToBeRefreshed ) {
                    return;
                }
                lastHarvestableName = currHarvestableName;
                EquipableObject[] eqObjs = colliderOnMouse.gameObject.GetComponents<EquipableObject>( );
                tooltipText.text = colliderOnMouse.gameObject.name + "\n";
                foreach( EquipableObject i in eqObjs ) {
                    tooltipText.text += i.objName + ": " + i.currObjects + "\n";
                }
                isTooltipToBeRefreshed = false;
            }
            else if( colliderOnMouse.gameObject.tag == Tags.Floor ) {
                if( Vector3.Distance( transform.position,
                                     colliderOnMouse.gameObject.transform.position) <= stats.buildDistance ) {
                    colliderOnMouse.gameObject.GetComponentInParent<BuildPlace>( ).HighlightTile( colliderOnMouse.gameObject.transform.position );
                    ResetTooltip( );
                }
            }
            else {
                ResetTooltip( );
            }
        }
        else {
            ResetTooltip( );
        }
    }

    void ResetTooltip( ) {
        tooltipText.text = "";
        isTooltipToBeRefreshed = true;
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

    void Jump( ) {
        if( !isAbleToJump ) {
            return;
        }
        GetComponent<Rigidbody>( ).AddForce( new Vector3( 0.0f,
                                                          stats.jumpForce,
                                                          0.0f),
                                            ForceMode.Force );
        isAbleToJump = false;
        timeFromLastJump = 0.0f;
    }

    void Pick( ) {
        isTooltipToBeRefreshed = true;
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
