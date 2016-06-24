using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {
    public GameObject enemy2;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Generate", 0, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Generate(){
        Instantiate(enemy2, transform.position, transform.rotation);
    }
}
