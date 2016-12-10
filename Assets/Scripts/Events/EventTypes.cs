using UnityEngine;
using System.Collections;

public enum EventTypes {
    playerForward,
    playerBackwards,
    playerLeft,
    playerRight,
    playerJump,
    playerPick,

    cameraUp,
    cameraDown,
    cameraLeft,
    cameraRight,

    showInventory,
    showStats,

    placeObject,
    rotateObject,
}