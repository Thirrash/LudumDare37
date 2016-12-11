using UnityEngine;
using System.Collections.Generic;

public class Book : MonoBehaviour {
    List<Recepiece> recepiece = new List<Recepiece>( );

    void Start( ) {
        recepiece.Add( new Wall1x4cs( gameObject ) );
        recepiece.Add( new Wall2x4( gameObject ) );
        recepiece.Add( new Wall4x4( gameObject ) );
        recepiece.Add( new Nail( gameObject ) );
    }


    void Update( ) {
	
    }


    public List<Recepiece> GetList( ) {
        return recepiece;
    }
}
