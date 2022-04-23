using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadLvl
{
    public static string Level;

    public static string LevelName
    {
        get { return Level; }

        set { Level = value; }
    }
}
