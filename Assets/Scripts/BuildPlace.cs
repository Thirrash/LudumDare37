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
    public int gridYSize = 50;
    Vector3 pos;
    public int[ , ] grid;
    GameObject[ , ] floorPiece;
    GameObject floorPrefab;
    GameObject lastHighlightedPiece;
    GameObject objectToPlace;

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
                lastHighlightedPiece = floorPiece[0, 0];

            }
        }
    }

    void Update( ) {
        lastHighlightedPiece.GetComponent<Renderer>( ).material.color = Color.white;
    }
        
    public void HighlightTile( Vector3 posToHighlight ) {
        Vector3 highlightPos = posToHighlight - pos;
        floorPiece[(int) highlightPos.x, (int) highlightPos.z].GetComponent<Renderer>( ).material.color = Color.blue;
        lastHighlightedPiece = floorPiece[(int) highlightPos.x,
                                          (int) highlightPos.z];
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

    public Vector3 GetTilePosition( int i, int j ) {
        return floorPiece[i, j].transform.position;
    }
}
