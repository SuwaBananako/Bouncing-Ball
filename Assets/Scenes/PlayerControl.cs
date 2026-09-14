using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x*turnSpeed*Time.deltaTime,0,speed*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale=1;
            return;
        }

        if (transform.position.x < -4 || transform.position.x > 4)
        {
            transform.Translate(0,-10*Time.deltaTime,0);
        }

        if (transform.position.y < -20)
        {
            Time.timeScale=0;
        }

        Transform c = Camera.main.transform;
        Quaternion cur = c.rotation;
        Quaternion target = cur*Quaternion.Euler(0,0,x*1.5f);
        Camera.main.transform.rotation = Quaternion.Slerp(cur,target,0.5f);
    }
}
