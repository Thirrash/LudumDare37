using UnityEngine;
using System.Collections;
using System;

public class EquipableObject : MonoBehaviour 
{
    [SerializeField] float _weight;
    public float weight {
        get {
            return _weight;
        }
        protected set {
            if( value < 0.0f ) {
                _weight = 0.0f;
            }
            else {
                _weight = value;
            }
        }
    }

    [SerializeField] string _objName;
    public string objName {
        get { return _objName; }
        protected set { _objName = value; }
    }

    [SerializeField] int _maxObjects;
    public int maxObjects {
        get { return _maxObjects; }
        protected set {
            if( value < 1 ) {
                _maxObjects = 1;
            }
            else
                _maxObjects = value;
        }
    }

	void Start () {
	
	}
	
	void Update () {
	
	}
}
