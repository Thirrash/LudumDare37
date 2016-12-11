using UnityEngine;
using System.Collections;

public class BuildPlace : MonoBehaviour
{
    static BuildPlace _instance;

    public static BuildPlace instance {
        get { return _instance; }
        private set { _instance = value; }
    }

    public int gridXSize = 50;
    public int gridZSize = 50;
    Vector3 pos;
    public int[ , ] grid;
    GameObject[ , ] floorPiece;
    GameObject floorPrefab;
    GameObject lastHighlightedPiece;
    GameObject objectToPlace;

    void Start( ) {
        instance = this;
        grid = new int[gridXSize, gridZSize];
        floorPiece = new GameObject[gridXSize, gridZSize];
        pos = new Vector3( transform.position.x - gridXSize / 2,
                          transform.position.y + 0.5f,
                          transform.position.z - gridZSize / 2);
        floorPrefab = Resources.Load( "FloorTile2" ) as GameObject;
        for( int i = 0; i < gridXSize; i++ ) {
            for( int j = 0; j < gridZSize; j++ ) {
                grid[i, j] = 0;
                floorPiece[i, j] = Instantiate( floorPrefab, new Vector3( pos.x + i,
                                                                          pos.y,
                                                                          pos.z + j), Quaternion.identity,
                                                gameObject.transform ) as GameObject;
                

            }
        }
        lastHighlightedPiece = floorPiece[0, 0];
    }

    void Update( ) {
        lastHighlightedPiece.GetComponentInChildren<Renderer>( ).material.color = Color.white;
    }
        
    public void HighlightTile( Vector3 posToHighlight ) {
        Vector3 highlightPos = posToHighlight - pos;
        floorPiece[(int) highlightPos.x, (int) highlightPos.z].GetComponentInChildren<Renderer>( ).material.color = Color.blue;
        lastHighlightedPiece = floorPiece[(int) highlightPos.x,
                                          (int) highlightPos.z];
    }

    public void PermanentlyHighlightTile( int i, int j ) {
        floorPiece[i, j].GetComponentInChildren<Renderer>( ).material.color = Color.green;
    }

    public bool CheckIfAvailable( int i, int j ) {
        return (grid[i, j] == 0);
    }

    public bool AddObject( int i, int j, int value ) {
        if( !CheckIfAvailable( i, j ) ) {
            return false;
        }
        grid[i, j] = value;
        return true;
    }

    public Vector3 GetTilePosition( int i, int j ) {
        return floorPiece[i, j].transform.position;
    }

    public int GetTileXFromPosition( float x ) {
        return (int) ( x - pos.x );
    }

    public int GetTileZFromPosition( float z ) {
        return (int) ( z - pos.z );
    }
}
