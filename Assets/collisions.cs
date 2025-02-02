using UnityEngine;

public class collisions : MonoBehaviour
{
    movement controller;
    void Start() {
        controller = GetComponent<movement>();
    }
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        GetComponent<Rigidbody>().useGravity = true;
        controller.enabled = false;
    }
}
