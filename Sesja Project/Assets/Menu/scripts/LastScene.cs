using UnityEngine;
using System.Collections;

public static class LastScene
{
    private static string lastScene;

    public static string myLastScene
    {
        get { return lastScene; }
        set { lastScene = value; }
    }
}
