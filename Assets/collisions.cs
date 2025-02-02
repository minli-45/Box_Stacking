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

    void OnCollisionStay(Collision other) {
        if (GetComponent<Transform>().rotation.eulerAngles.z > 5f || GetComponent<Transform>().rotation.eulerAngles.z < -5f) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (GetComponent<Transform>().rotation.eulerAngles.x > 5f || GetComponent<Transform>().rotation.eulerAngles.x < -5f) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
