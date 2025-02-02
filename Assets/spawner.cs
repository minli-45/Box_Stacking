using UnityEngine;

public class spawner : MonoBehaviour
{  
    public GameObject BasicBox;
    private GameObject box;
    private float PalletSideLength = 1.2f;
    private Vector3 scaleChange;
    private Vector3 centerOffset;
    private bool BoxFalling = false;
    Vector3 randomSize() {
        Vector3 boxSize = new Vector3((1f/Random.Range(2,6))*PalletSideLength, Random.Range(0f, 0.5f),(1f/Random.Range(2,6))*PalletSideLength);
        return boxSize;
    }

    void Update()
    {   
        if (Input.GetKeyDown("space") && BoxFalling == false) {
            scaleChange = randomSize();
            centerOffset = new Vector3((PalletSideLength-scaleChange.x)/2, 0, (PalletSideLength-scaleChange.z)/2);
            box = Instantiate(BasicBox, transform.position + centerOffset, Quaternion.identity);
            box.transform.localScale += scaleChange;
            box.GetComponent<movement>().enabled = true;
            BoxFalling = true;
        }
        if (box.GetComponent<collisions>().canFall) {
            BoxFalling = false;
        }
    }
}
