using UnityEngine;
using System.Collections;

public class PlacableObject : Resource 
{
    public int length;
    public int width;
    public int tileXStart;
    public int tileYStart;
    public GameObject prefab;
    GameObject instantiatedPrefab;
    bool isObjectVisible = false;

	protected override void Start () {
        base.Start( );
	}

    public void SetObject( int tileX, int tileY ) {
        if( !CheckIfPlacementPossible( tileX, tileY ) ) {
            return;
        }
        else {
            if( isObjectVisible ) {
                Destroy( instantiatedPrefab );
                isObjectVisible = false;
            }

            tileXStart = tileX;
            tileYStart = tileY;
            instantiatedPrefab = Instantiate( prefab,
                                             BuildPlace.instance.GetTilePosition( tileX,
                                                                                         tileY),
                                             Quaternion.identity,
                                             BuildPlace.instance.transform.parent) as GameObject;
        }
    }

    bool CheckIfPlacementPossible( int tileX, int tileY ) {
        for( int i = 0; i < length; i++ ) {
            for( int j = 0; j < width; j++ ) {
                //if( tileX + length > 
                if( BuildPlace.instance.grid[i, j] != 0 ) {

                }
            }
        }
        return true; //delete this
    }
}
