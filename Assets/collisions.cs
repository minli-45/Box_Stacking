using UnityEngine;
using UnityEngine.SceneManagement;

public class collisions : MonoBehaviour
{
    public bool canFall = false;
    public bool reset = false;
    public bool stop = false;
    movement controller;
    void Start() {
        controller = GetComponent<movement>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Box" || other.gameObject.tag == "Ground"){
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            GetComponent<Rigidbody>().useGravity = true;
            controller.enabled = false;
            canFall = true;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Border") {
            reset = true;
        }

        if (other.gameObject.tag == "Ceiling" && !controller.enabled) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Ceiling" && !controller.enabled) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
