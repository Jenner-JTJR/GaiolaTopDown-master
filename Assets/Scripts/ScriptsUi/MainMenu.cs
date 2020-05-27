using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string GameScene;
    public GameObject AudioScript;
    public GameObject Som;

    public void PlayGame ()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(AudioScript,SceneManager.GetSceneByBuildIndex(1));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(0);
    }
}
