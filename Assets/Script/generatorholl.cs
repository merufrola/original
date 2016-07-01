using UnityEngine;
using System.Collections;


public class generatorholl : MonoBehaviour {
   public  Vector3[] spot = new Vector3[5];
            

	// Use this for initialization
	void Start () {
        spot[0] = new Vector3(-19, 0.5f,-64);
        spot[1] = new Vector3(-68, 0.5f, -34);
        spot[2] = new Vector3(-30, 0.5f, -48);
        spot[3] = new Vector3(-43.5f, 0.5f, -78);
        spot[4] = new Vector3(-72,0.5f,-60);
       
        this.transform.position = spot[Random.Range(0, spot.Length)];
    }
	
	// Update is called once per frame
	void Update () {
	


	}

    void Damage()
    {
        
            Destroy(this.gameObject);
        
      
    }
}
