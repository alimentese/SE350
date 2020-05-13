using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
   
    public void BacktoMainScreen(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void BacktoClassSelect(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void KnightSelected(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void stageOne(string scene) {
        SceneManager.LoadScene(scene);
    }
}
