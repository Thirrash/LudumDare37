using UnityEngine;
using System.Collections;

[RequireComponent (typeof (PlayerSkills))]
public class PlayerStatistics : MonoBehaviour 
{
    public PlayerSkills skills { get; private set; }
    public float pickDistance = 1.0f;

    [SerializeField] float _movementVerticalSpeed;
    public float movementVerticalSpeed {
        get {
            return (Time.timeScale == 0.0f) ? (_movementVerticalSpeed) : (_movementVerticalSpeed * Time.deltaTime);
        }
        set {
            _movementVerticalSpeed = value;
        }
    }

    [SerializeField] float _movementHorizontalSpeed;
    public float movementHorizontalSpeed {
        get {
            return (Time.timeScale == 0.0f) ? (_movementHorizontalSpeed) : (_movementHorizontalSpeed * Time.deltaTime);
        }
        set {
            _movementHorizontalSpeed = value;
        }
    }

    [SerializeField] float _cameraSpeed;
    public float cameraSpeed {
        get {
            return _cameraSpeed * Time.deltaTime;
        }
        set {
            _cameraSpeed = value;
        }
    }

    [SerializeField] float _maxWeight;
    public float maxWeight {
        get {
            return _maxWeight;
        }
        set {
            if( value < 0.0f ) {
                _maxWeight = 0.0f;
            }
            else {
                _maxWeight = value;
            }
        }
    }

    [SerializeField] float _jumpForce;
    public float jumpForce {
        get { return _jumpForce; }
        set { _jumpForce = value; }
    }

    [SerializeField] float _timeBetweenJumps;
    public float timeBetweenJumps {
        get { return _timeBetweenJumps; }
        set { _timeBetweenJumps = value; }
    }

    public float currWeight = 0.0f;

    // Use this for initialization
    void Start () {
        skills = GetComponent<PlayerSkills>( );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
