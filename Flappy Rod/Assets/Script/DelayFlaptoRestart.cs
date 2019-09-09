using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayFlaptoRestart : MonoBehaviour
{
    public GameObject flapToRestart;
    public int delay = 1;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Invoke("EnableflapToRestart", delay);  
    }
    
    void EnableflapToRestart()
    {
        flapToRestart.SetActive(true);
    }    
   

    // Update is called once per frame
    
}
