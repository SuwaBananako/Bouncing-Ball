using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
     
    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Player")
        {
           
            Time.timeScale = 0;
        }
    }

  
    // Update is called once per frame
    void Update()
    {
        
    }
}
