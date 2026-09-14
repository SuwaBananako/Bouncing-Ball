using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    GameObject endUI;
    private void Start()
    {
        endUI = GameObject.Find("EndUI");
        endUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("นýนุ");
            Time.timeScale = 0;
            endUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
