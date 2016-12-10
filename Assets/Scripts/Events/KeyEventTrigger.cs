﻿using UnityEngine;
using System.Collections;

using Globals;
public class KeyEventTrigger : MonoBehaviour 
{
	void Update( ) {
        if( Input.GetAxis( PlayerInput.Vertical ) > 0.0f ) {
            EventManager.TriggerEvent( EventTypes.playerForward );
        }
        else if( Input.GetAxis( PlayerInput.Vertical ) < 0.0f ) {
            EventManager.TriggerEvent( EventTypes.playerBackwards );
        }

        if( Input.GetAxis( PlayerInput.Horizontal ) > 0.0f ) {
            EventManager.TriggerEvent( EventTypes.playerRight );
        }
        else if( Input.GetAxis( PlayerInput.Horizontal ) < 0.0f ) {
            EventManager.TriggerEvent( EventTypes.playerLeft );
        }

        if( Input.GetAxis( PlayerInput.MouseX ) > 0.0f ) {
            EventManager.TriggerEvent( EventTypes.cameraRight );
        }
        else if( Input.GetAxis( PlayerInput.MouseX ) < 0.0f ) {
            EventManager.TriggerEvent( EventTypes.cameraLeft ); 
        }

        if( Input.GetAxis(PlayerInput.MouseY ) > 0.0f ) {
            EventManager.TriggerEvent( EventTypes.cameraDown );
        }
        else if( Input.GetAxis( PlayerInput.MouseY ) < 0.0f ) {
            EventManager.TriggerEvent( EventTypes.cameraUp );
        }

        if( Input.GetButton( PlayerInput.Inventory ) ) {
            EventManager.TriggerEvent( EventTypes.showInventory );
        }

        if( Input.GetButton( PlayerInput.Stats ) ) {
            EventManager.TriggerEvent( EventTypes.showStats );
        }
	}
}
