using UnityEngine;

public class movement : MonoBehaviour
{
    float horizontalMovement;
    float horizontalDistance;
    float verticalMovement;
    float verticalDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0f, -0.5f, 0f, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdates() {
        moveBox();
    }

    void moveBox() {
        if (horizontalMovement != 0) {

        }
    }
}
