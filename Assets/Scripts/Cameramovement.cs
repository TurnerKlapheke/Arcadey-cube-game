using UnityEngine;

public class Cameramovement : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
       target.GetComponent<Transform>();
    }

    void LateUpdate () 
    {
        transform.position = target.position + offset;
    }
   
}
