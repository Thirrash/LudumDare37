using UnityEngine;
using System.Collections;

public class BuildPlace : MonoBehaviour
{
    BuildPlace _instance;

    public BuildPlace instance {
        get { return _instance; }
        private set { _instance = value; }
    }

    public int gridXSize = 50;
    public int gridYSize = 50;
    Vector3 pos;
    public int[ , ] grid;
    GameObject[ , ] floorPiece;
    GameObject floorPrefab;

    void Start( ) {
        instance = this;
        grid = new int[gridXSize, gridYSize];
        floorPiece = new GameObject[gridXSize, gridYSize];
        pos = new Vector3( transform.position.x - gridXSize / 2,
                          transform.position.y + 0.5f,
                          transform.position.z - gridYSize / 2);
        floorPrefab = Resources.Load( "FloorTile" ) as GameObject;
        for( int i = 0; i < gridXSize; i++ ) {
            for( int j = 0; j < gridYSize; j++ ) {
                grid[i, j] = 0;
                floorPiece[i, j] = Instantiate( floorPrefab, new Vector3( pos.x + i,
                                                                          pos.y,
                                                                          pos.z + j), Quaternion.identity,
                                                gameObject.transform ) as GameObject;

            }
        }
    }

    void Update( ) {

    }
        

    public bool CheckIfAvailable( int i, int j ) {
        return (grid[i, j] == 0);
    }

    public void AddObject( int i, int j, int value ) {
        if( !CheckIfAvailable( i, j ) ) {
            return;
        }
        grid[i, j] = value;
    }

}
