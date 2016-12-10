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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
