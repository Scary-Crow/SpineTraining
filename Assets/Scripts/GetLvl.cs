using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetLvl : MonoBehaviour
{
  public void Scene()
    {
        string nameScene = LoadLvl.LevelName;

        SceneManager.LoadScene(nameScene);
    }
}
