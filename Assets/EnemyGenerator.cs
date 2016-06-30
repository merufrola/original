using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {
    public GameObject enemy2;
    public GameObject enemy3;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Generate", 0, 5);
        InvokeRepeating("Generate2", 0, 15);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Generate(){
        Instantiate(enemy2, transform.position, transform.rotation);
    }

    void Generate2()
    {
        Instantiate(enemy3, transform.position, transform.rotation);
    }
}
