using UnityEngine;

public class collisions : MonoBehaviour
{
    public bool canFall = false;
    movement controller;
    void Start() {
        controller = GetComponent<movement>();
    }
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        GetComponent<Rigidbody>().useGravity = true;
        controller.enabled = false;
        canFall = true;
    }
}
