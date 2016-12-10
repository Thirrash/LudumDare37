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

    string _objName;
    public string objName {
        get { return _objName; }
        protected set { _objName = value; }
    }

    [SerializeField] int _currObjects;
    public int currObjects {
        get { return _currObjects; }
        set {
            if( value < 0 ) {
                _currObjects = 0;
            }
            else
                _currObjects = value;
        }
    }

    protected virtual void Start( ) {

    }

    public void IncreaseObjectQuantity(int value) {
        currObjects += value;
    }

    public void DecreaseObjectQuantity(int value) {
        if( (currObjects - value) < 0 ) {
            EquipableObject[] stillOnGameobject = GetComponents<EquipableObject>( );
            if( stillOnGameobject == null ) {
                Destroy( gameObject );
            }
            else {
                Destroy( this );
            }
        }
        else {
            currObjects -= value;
        }
    }
}
