using UnityEngine;
using System.Collections;

public class PlayerStatistics : MonoBehaviour 
{
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
    public float maxWeight
    {
        get
        {
            return _cameraSpeed * Time.deltaTime;
        }
        set
        {
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

    [SerializeField] int _woodSkill;
    public float woodSkill {
        get {
            return _woodSkill;
        }
        set {
            _woodSkill += value;
        }
    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
