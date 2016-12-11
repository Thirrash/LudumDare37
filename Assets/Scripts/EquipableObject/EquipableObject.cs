using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class EquipableObject : MonoBehaviour
{
    [SerializeField] float _weight;
    public float weight {
        get {
            return _weight;
        }
        set {
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
        set { _objName = value; }
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

    public Image avatar;

    protected virtual void Start( ) {

    }

    public void IncreaseObjectQuantity( int value ) {
        currObjects += value;
    }

    public void DecreaseObjectQuantity( int value ) {
        if( (currObjects - value) <= 0 ) {
            EquipableObject[] stillOnGameobject = GetComponents<EquipableObject>( );

            if( !CheckIfOtherEquipableObjects( stillOnGameobject ) && (gameObject.tag != "Player") ) {
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

    bool CheckIfOtherEquipableObjects( EquipableObject[] objs ) {
        foreach( EquipableObject i in objs ) {
            if( i.objName != objName ) {
                return true;
            }
        }

        return false;
    }
}
