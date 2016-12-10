using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class ObjectEvent
{
    List<Action> listeners = new List<Action>( );

    public void AddListener( Action e ) {
        listeners.Add( e );
    }

    public void RemoveListener( Action e ) {
        listeners.Remove( e );
    }

    public void Invoke( object o = null ) {
        for( int i = listeners.Count - 1; i >= 0; --i )
            listeners[i]( );
    }
}

public class EventManager
{
    private static EventManager eventManager;

    public static EventManager instance {
        get {
            if( eventManager == null ) {
                eventManager = new EventManager( );
                eventManager.eventDictionary = new Dictionary<EventTypes, ObjectEvent>( );
            }
            return eventManager;
        }
    }

    private Dictionary<EventTypes, ObjectEvent> eventDictionary;
    private ObjectEvent tmp;

    public static void StartListening( EventTypes eventName, Action listener ) {
        if( instance.eventDictionary.TryGetValue( eventName, out instance.tmp ) ) {
            instance.tmp.AddListener( listener );
        }
        else {
            instance.tmp = new ObjectEvent( );
            instance.tmp.AddListener( listener );
            instance.eventDictionary.Add( eventName, instance.tmp );
        }
    }

    public static void StopListening( EventTypes eventName, Action listener ) {
        if( instance.eventDictionary.TryGetValue( eventName, out instance.tmp ) )
            instance.tmp.RemoveListener( listener );
    }

    public static void TriggerEvent( EventTypes eventName,
                                     object sender = null ) {
        if( instance.eventDictionary.TryGetValue( eventName, out instance.tmp ) )
            instance.tmp.Invoke( sender );
    }
}
