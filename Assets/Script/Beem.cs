using UnityEngine;
using System.Collections;

public class Beem : MonoBehaviour {
    float timer = 0.0f;
    float effectDisplayTime = 0.2f;
    ParticleSystem beamParticle;

    // Use this for initialization
    void Start () {

        beamParticle = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            shot();
        }
        if (timer >= effectDisplayTime)
        {
            disableEffect();
        }

    }
    void shot()
    {
        timer = 0f;
       // GameObject.Find("par1").transform.Rotate(Unitychan.hit);
        beamParticle.Stop();
        beamParticle.Play();

    }
    private void disableEffect()
    {
        beamParticle.Stop();
     
    }


}
