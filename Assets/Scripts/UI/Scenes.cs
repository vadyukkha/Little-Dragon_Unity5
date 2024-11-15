using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public static int lastScene;

    public void ChangeScene(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
        lastScene = numberScenes;
    }

    public void Continue()
    { 
        SceneManager.LoadScene(lastScene);
    } 
    public void Exit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {   
        SceneManager.LoadScene(0);
    }
}
