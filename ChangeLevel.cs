using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // <----------------- YOU NEED THIS OR THE SCENEMANAGER IS WHITE

public class ChangeLevel : MonoBehaviour
{
    public int sceneNumber;
    public string sceneName;

    public GameObject ObjectToEnable;

    public void changeSceneNumber()
    {
        SceneManager.LoadScene(sceneBuildIndex: sceneNumber);
        Time.timeScale = 1f;
    }

    public void changeSceneName()
    {
        SceneManager.LoadScene(sceneName: sceneName);
        Time.timeScale = 1f;
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void enableDisable()
    {
        if(ObjectToEnable.active == false)
        {
            ObjectToEnable.SetActive(true);
        }

        else if (ObjectToEnable.active == true)
        {
            ObjectToEnable.SetActive(false);
        }
    }


}
