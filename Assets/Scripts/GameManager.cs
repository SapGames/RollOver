using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Nothing
    bool gamehasEnded = false;

    public GameObject movement;

    public float restartdelay = 10f;

    public GameObject completeLevelUI;

    public GameObject lossLevelUI;

    public void CompleteLevel () 
    {
        completeLevelUI.SetActive(true);
        movement.SetActive(false);
    }

    public void EndGame ()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("GAME OVER");
            lossLevelUI.SetActive(true);
            Invoke("Restart", restartdelay);
        }
        
    }

    public void Restart () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        completeLevelUI.SetActive(false);
    }
}
