using UnityEngine;
using System.Collections;

namespace Globals
{
    #region Static Constants
    public static class PlayerInput {
        public static string Horizontal = "Horizontal";
        public static string Vertical = "Vertical";
        public static string Jump = "Jump";
        public static string MouseX = "MouseX";
        public static string MouseY = "MouseY";
        public static string MouseScroll = "Mouse ScrollWheel";
        public static string Fire1 = "Fire1";
        public static string Fire2 = "Fire2";
        public static string Fire3 = "Fire3";
        public static string Run = "Run";
        public static string Cancel = "Cancel";
        public static string Submit = "Submit";
        public static string Inventory = "Inventory";
        public static string Stats = "Stats";
        public static string RotatePlacable = "RotatePlacable";
    }

    public static class Tags {
        public static string Harvestable = "Harvestable";
        public static string Floor = "Floor";
        public static string Placed = "Placed";
    }
    #endregion

    public struct Material {
        public string name;
        public int howMany;

        public Material( string Name, int howMany ) {
            name = Name;
            this.howMany = howMany;
        }

        public Material( string _name ) {
            name = _name;
            this.howMany = 1;
        }
    }
}


