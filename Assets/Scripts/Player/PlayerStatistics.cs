using UnityEngine;
using System.Collections;

[RequireComponent (typeof (PlayerSkills))]
public class PlayerStatistics : MonoBehaviour 
{
    public PlayerSkills skills { get; private set; }

    [SerializeField] float _movementVerticalSpeed;
    public float movementVerticalSpeed {
        get {
            return _movementVerticalSpeed * Time.deltaTime;
        }
        set {
            _movementVerticalSpeed = value;
        }
    }

    [SerializeField] float _movementHorizontalSpeed;
    public float movementHorizontalSpeed {
        get {
            return _movementHorizontalSpeed * Time.deltaTime;
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

    public float currWeight = 0.0f;

    // Use this for initialization
    void Start () {
        skills = GetComponent<PlayerSkills>( );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
