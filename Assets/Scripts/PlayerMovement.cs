using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //this establishes variable rb as a rigidbody interaction
   public Rigidbody rb;

    //movement variable
   public float forwardforce = 2000f;
   public float sidewaysforce = 500f;
    
    // Start is called before the first frame update
    void Start() {
        // This establishes thet variable rb is calling this objects rigidbody
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Using Fixed update so unity hates me less
    void FixedUpdate() 
    {
        //add a forward force
       rb.AddForce(0 ,0 ,forwardforce * Time.deltaTime);
   
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }

    }
}
