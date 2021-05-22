using UnityEngine;



public struct CameraBounds
{
        
    public static Vector2 Max
    {
        get
        {
            Vector2 topRight = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
            return topRight;
        }

    }

    public static Vector2 Min
    {
        get
        {
            Vector2 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            return bottomLeft;
        }
    }

}

