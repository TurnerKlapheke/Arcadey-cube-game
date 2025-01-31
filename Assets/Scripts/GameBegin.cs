using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBegin : MonoBehaviour
{

    public void Begingame () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    

}
