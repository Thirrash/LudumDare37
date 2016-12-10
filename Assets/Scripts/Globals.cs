﻿using UnityEngine;
using System.Collections;

namespace Globals
{
    #region Static Constants
    public static class PlayerInput
    {
        public static string Horizontal   = "Horizontal";
        public static string Vertical     = "Vertical";
        public static string Jump         = "Jump";
        public static string MouseX       = "Mouse X";
        public static string MouseY       = "Mouse Y";
        public static string MouseScroll  = "Mouse ScrollWheel";
        public static string Fire1        = "Fire1";
        public static string Fire2        = "Fire2";
        public static string Fire3        = "Fire3";
        public static string Run          = "Run";
        public static string Cancel       = "Cancel";
        public static string Submit       = "Submit";
    }

    public static class AnimatorCondiotion
    {
        public static string Speed          ="Speed";
        public static string Direction      = "Direction";
        public static string Grounded       = "Grounded";
        public static string AirVelocity    = "Air Velocity";
    }

    public static class AnimatorLayer
    {
        public static int BaseLayer = 0;
        public static int UpperBody = 1;
        public static int LowerBody = 2;
    }
    #endregion
}
