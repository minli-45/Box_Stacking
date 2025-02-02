using UnityEngine;

public class collisions : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
