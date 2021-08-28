using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel0 : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar; 
    public int LevelNumber;
    
    public void LoadScene(int level) 
    {
        StartCoroutine(LoadAsynchronously(level));
    }

    IEnumerator LoadAsynchronously (int level) 
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(LevelNumber);

        loadingScreen.SetActive(true);

        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            loadingBar.value = progress;

            yield return null;
        }
    }
}
