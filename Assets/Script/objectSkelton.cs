using UnityEngine;
using System.Collections;

public class objectSkelton : MonoBehaviour {
    MeshRenderer meshrender;
	// Use this for initialization
	void Start () {
        meshrender = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        meshrender.material.color = new Color(0, 0, 0, 0.1f);
	}
}
