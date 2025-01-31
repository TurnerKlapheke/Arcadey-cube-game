using UnityEngine;

public class Collisionscript : MonoBehaviour{

public PlayerMovement Movement;

    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false;

            FindObjectOfType<gamemanager>().EndGame();

        }
    }


}
