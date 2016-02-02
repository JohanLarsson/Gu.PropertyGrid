﻿namespace Gu.Wpf.PropertyGrid
{
    internal static class BooleanBoxes
    {
        internal static readonly object True = true;
        internal static readonly object False = false;

        internal static object Box(bool value)
        {
            if (value)
            {
                return True;
            }
            else
            {
                return False;
            }
        }
    }
}