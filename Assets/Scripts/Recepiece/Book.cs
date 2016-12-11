using UnityEngine;
using System.Collections.Generic;

public class Book : MonoBehaviour {
    List<Recepiece> recepiece = new List<Recepiece>( );

    void Start( ) {
        recepiece.Add( new Wall1x4cs( gameObject ) );
        recepiece.Add( new Wall2x4( gameObject ) );
        recepiece.Add( new Wall4x4( gameObject ) );
        recepiece.Add( new Wall4x4Window( gameObject ) );
        recepiece.Add( new Bed( gameObject ) );
        recepiece.Add( new Chair( gameObject ) );
        recepiece.Add( new Door( gameObject ) );
        recepiece.Add( new Drawer( gameObject ) );
        recepiece.Add( new HugeLamp( gameObject ) );
        recepiece.Add( new SmallLamp( gameObject ) );
        recepiece.Add( new Table( gameObject ) );
        recepiece.Add( new Nail( gameObject ) );
    }


    void Update( ) {
	
    }


    public List<Recepiece> GetList( ) {
        return recepiece;
    }
}
