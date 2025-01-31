using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour{
    

    bool gameover = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void completelevel () 
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() 
    {

        if (gameover == false)
        {
        gameover = true;
        Debug.Log("game has ended");
        // restart game
        Invoke("restart", restartDelay);
        }

    }


    void restart () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
