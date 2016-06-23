using UnityEngine;
using System.Collections;

public class Unitychan : MonoBehaviour {
    Animator animator;
    public float speed = 5.0f;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            float pos_x = transform.position.x;
        }



        if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            animator.SetBool("TurnL", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("TurnL", false);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("RUn", true);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("RUn", false);
        }

        TRP();
	}
    void TRP()
    {
        int distance = 10;
        
    }

    void OnCollisionEnter(Collision col)
    {

        Debug.Log(col.collider.name);
    }
}
