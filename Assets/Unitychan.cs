﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Unitychan : MonoBehaviour
{
    public Text timermj;
    static float timer = 0.0f;
    public Camera camera;
    public GameObject raicleCanvas;
    public Image image;
    public static float stoptime;
    public static int Flag;
    int HP = 10;
    public Text HPlabel;
    public Image HPBar;
    public static RaycastHit hit;
    public static Ray ray;
    // Use this for initialization
    void Start()
    {
        // image = gameObject.GetComponent<Image>();
        image.enabled = false;
        Flag = 1;


       
    }
    // Update is called once per frame
    void Update()
    {
        HPlabel.text = HP.ToString();
        if (Flag == 1)
        {
            timer += Time.deltaTime;
            timermj.text = timer.ToString("f2");
        }



        TRP();
        if (Input.GetKey("a")) {
            stoptime = timer;
        Debug.Log(stoptime);
        Invoke("Clear", 1.0f);
    }

        Debug.Log(HP);
        if(HP <= 0)
        {
            SceneManager.LoadScene("Gameover");
        };
    }

    void TRP()
    {
      
        int distance = 5;
        ray = new Ray(transform.position + new Vector3(-1, 0.3f, 0), transform.forward);
        
        if (Physics.SphereCast(ray,2, out hit, distance))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            image.enabled = true;

            raicleCanvas.transform.position = hit.point;
            if (hit.collider.tag == "Ganarator" && Input.GetKey(KeyCode.Space))
            //
            {
                Debug.Log(hit.collider.tag);
                hit.collider.transform.parent.SendMessage("Damage");
                stoptime = timer;
                Debug.Log(timer);
                Invoke("Clear", 1.0f);

            }

                if (Input.GetMouseButtonDown(0)) 
                //
                {
                 if (hit.collider.tag == "Enemy")
                    {
                    Debug.Log("b");
                    hit.collider.transform.parent.SendMessage("Damage");
                 }
                    
                }
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    


    void Clear()
    {
        Debug.Log(timer);
        SceneManager.LoadScene("Clear!");
    }

   

    void PDamage()
    {
        HP --;
        HPBar.fillAmount -= 0.1f;

    }
   
}
