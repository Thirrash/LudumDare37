﻿using UnityEngine;
using System.Collections;

public class PlacableObject : Resource {
    public int length;
    public int width;
    public int tileXStart;
    public int tileYStart;
    public GameObject prefab;
    Quaternion prefabBaseRot;
    GameObject instantiatedPrefab;
    bool isObjectToBeSet = false;
    int rotateState = 0;

    protected override void Start( ) {
        base.Start( );
        prefabBaseRot = prefab.transform.rotation;
    }

    void OnDestroy( ) {
        prefab.transform.rotation = prefabBaseRot;
    }

    public GameObject SetObject( int tileX, int tileY, bool isPreview ) {
        if( isPreview && instantiatedPrefab != null ) {
            Destroy( instantiatedPrefab );
            for( int i = tileXStart; i < tileXStart + length; i++ ) {
                for( int j = tileYStart; j < tileYStart + width; j++ ) {
                    BuildPlace.instance.AddObject( i, j, 0 );
                }
            }
        }

        tileXStart = tileX;
        tileYStart = tileY;

        bool errorPlacementFlag = false;
        for( int i = tileXStart; i < tileXStart + length; i++ ) {
            for( int j = tileYStart; j < tileYStart + width; j++ ) {
                if( !CheckIfPlacementPossible( i, j ) ) {
                    errorPlacementFlag = true;
                    break;
                }
            }
            if( errorPlacementFlag ) {
                return null;
            }
        }


        instantiatedPrefab = Instantiate( prefab,
            BuildPlace.instance.GetTilePosition( tileX,
                tileY ),
            prefab.transform.rotation,
            BuildPlace.instance.transform.parent ) as GameObject;
        
        for( int i = tileXStart; i < tileXStart + length; i++ ) {
            for( int j = tileYStart; j < tileYStart + width; j++ ) {
                if( isPreview ) {
                    BuildPlace.instance.AddObject( i, j, 0 );
                }
                else {
                    BuildPlace.instance.AddObject( i, j, 1 );
                }

                //BuildPlace.instance.PermanentlyHighlightTile( i, j );
            }
        }



        if( !isPreview ) {
            instantiatedPrefab.GetComponent<BoxCollider>( ).enabled = true;
            instantiatedPrefab = null;
        }
        return instantiatedPrefab;
    }

    bool CheckIfPlacementPossible( int tileX, int tileY ) {
        if( tileX + length - 1 >= BuildPlace.instance.gridXSize || tileX + length + 1 < 0 ) {
            return false;
        }
        if( tileY + width - 1 >= BuildPlace.instance.gridZSize || tileY + width + 1 < 0 ) {
            return false;
        }
        if( !BuildPlace.instance.CheckIfAvailable( tileX, tileY ) ) {
            return false;
        }
        return true;
    }

    public void Rotate( ) {
        int tmpLength = length;
        length = width;
        width = -tmpLength;
        rotateState = (rotateState + 1) % 4;
        Quaternion tmpQuaternion = Quaternion.Euler( new Vector3( prefab.transform.rotation.eulerAngles.x,
                                           prefab.transform.rotation.eulerAngles.y + 90.0f,
                                           prefab.transform.rotation.eulerAngles.z ) );
        prefab.transform.rotation = tmpQuaternion;
    }
}
