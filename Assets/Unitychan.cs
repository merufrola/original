using UnityEngine;
using System.Collections;

public class Unitychan : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {


        TRP();
	}

    void TRP()
    {
        RaycastHit hit;
        int distance = 10;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, distance))
        {
            Debug.DrawLine(ray.origin,hit.point,Color.red);

        }

        }

    void OnCollisionEnter(Collision col)
    {

        Debug.Log(col.collider.name);
    }
}
