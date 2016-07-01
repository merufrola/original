using UnityEngine;
using System.Collections;
public class enemy : MonoBehaviour
{
    private float speed = 1f;
    private float rotationSmooth = 1f;

    private Vector3 targetPosition ;

    private float changeTargetSqrDistance = 10f;

    [SerializeField]
    public  Vector3[] XZ = new Vector3[12];

    private void Start()
    {
      // targetPosition = GetRandomPositionOnLevel();

    }

    private void Update()
    {
       
       // gameObject.GetComponent<NavMeshAgent>().SetDestination(new Vector3(element2, 1.1f, element));
        //transform.position = new Vector3 (-12, 1.1f, element);


        // 目標地点との距離が小さければ、次のランダムな目標地点を設定する
         float sqrDistanceToTarget = Vector3.SqrMagnitude(transform.position - targetPosition);
        if (sqrDistanceToTarget < changeTargetSqrDistance)
        {
          targetPosition = GetRandomPositionOnLevel();
        }

        // 目標地点の方向を向く
        Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

        // 前方に進む
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (this.transform.position.y <= 0 ){
            Destroy(this.gameObject);
        }
        
    }

    void OnCollisionEnter()
    {
       if (gameObject.CompareTag("wall"))
        {
           // move to this object to above.
            targetPosition = GetRandomPositionOnLevel();
        }

    }

    public Vector3 GetRandomPositionOnLevel()
    {
        //var element = Z[Random.Range(0, Z.Length)];
        //var element2 = X[Random.Range(0, X.Length)];
        float levelSize = 55f;
        return XZ[Random.Range(0, XZ.Length)];
   }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent.SendMessage("PDamage");
        }
    }

    void Damage()
    {

        Destroy(this.gameObject);

   }
}