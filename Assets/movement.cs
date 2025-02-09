using UnityEngine;

public class movement : MonoBehaviour
{
    bool moveLeft;
    bool moveRight;
    bool moveUp;
    bool moveDown;
    bool rotateRight;
    bool rotateLeft;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0f, -0.2f, 0f, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft = Input.GetKeyDown("a");
        moveRight = Input.GetKeyDown("d");
        moveUp = Input.GetKeyDown("w");
        moveDown = Input.GetKeyDown("s");
        rotateRight = Input.GetKeyDown("e");
        rotateLeft = Input.GetKeyDown("q");
        moveBox();
    }

    void moveBox() {
        if (moveLeft) {
            GetComponent<Transform>().position += new Vector3(-GetComponent<Transform>().lossyScale.x,0,0);
        }
        if (moveRight) {
            GetComponent<Transform>().position += new Vector3(GetComponent<Transform>().lossyScale.x,0,0);
        }
        if (moveUp) {
            GetComponent<Transform>().position += new Vector3(0,0,GetComponent<Transform>().lossyScale.z);
        }
        if (moveDown) {
            GetComponent<Transform>().position += new Vector3(0,0,-GetComponent<Transform>().lossyScale.z);
        }
        if (rotateLeft) {
            GetComponent<Transform>().Rotate(0,-90,0);
        }
        if (rotateRight) {
            GetComponent<Transform>().Rotate(0,90,0);
        }
    }
}
