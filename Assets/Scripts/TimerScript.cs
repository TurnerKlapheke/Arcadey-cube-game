using UnityEngine; 
using UnityEngine.UI; 
using System.Collections;  

public class TimerScript : MonoBehaviour 
 {    
    public Text counterText;  
    public float seconds, minutes;          

public void pause () 
{
    this.enabled = false;
}

// Use this for initialization    
void Start () 
{        
counterText = GetComponent<Text>() as Text;   
}     

//update is called once per frame     
void Update () 
    {         
    minutes = (int)(Time.time /60f);         
    seconds = (int)(Time.time % 60f);         
    counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");     
    } 

}
