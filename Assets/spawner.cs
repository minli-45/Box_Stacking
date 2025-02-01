using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform BasicBox;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            Debug.Log("pressed space");
        }
    }
}
