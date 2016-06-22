using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Generate", 0, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Generte (){
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
