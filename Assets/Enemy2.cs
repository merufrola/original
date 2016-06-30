using UnityEngine;
using System.Collections;
public class Enemy2 : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;


    private void Start()
    {
        GameObject player = GameObject.Find("SD_unitychan_humanoid2 (2)");
        target = player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(target.position);
       



    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("c");
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("PDamage");
        }
    }

    void Damage()
    {

        Destroy(this.gameObject);

    }
}