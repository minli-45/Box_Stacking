using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour
{  
    public GameObject BasicBox;
    private GameObject box;
    private float PalletSideLength = 1.2f;
    private Vector3 scaleChange;
    private bool spawnCube;
    private bool moving;
    // Update is called once per frame
    Vector3 randomSize() {
        Vector3 boxSize = new Vector3((1f/Random.Range(2,6))*PalletSideLength, Random.Range(0f, 0.5f),(1f/Random.Range(2,6))*PalletSideLength);
        return boxSize;
    }
   
    void Update()
    {
        bool ObjectOnScreen = false;
        if (Input.GetKeyDown("space") && ObjectOnScreen == false) {
            scaleChange = randomSize();
            box = Instantiate(BasicBox, transform.position, Quaternion.identity);
            box.transform.localScale += scaleChange;
            box.GetComponent<Rigidbody>().AddForce(0f, -0.5f, 0f, ForceMode.VelocityChange);            
        }
    }
}
