using UnityEngine;

public class spawner : MonoBehaviour
{  
    public GameObject BasicBox;
    private GameObject box;
    private float PalletSideLength = 1.2f;
    private Vector3 scaleChange;
    private Vector3 centerOffset;
    private bool BoxFalling = false;
    private Vector3 restartingPosition;
    private int nbBoxes;
    Vector3 randomSize() {
        Vector3 boxSize = new Vector3((1f/Random.Range(2,6))*PalletSideLength, Random.Range(0.1f, 0.5f),(1f/Random.Range(2,6))*PalletSideLength);
        return boxSize;
    }

    void resetBox() {
        box.transform.position = restartingPosition;
        box.GetComponent<collisions>().reset = false;
    }

    void Update()
    {   
        if (Input.GetKeyDown("space") && BoxFalling == false) {
            scaleChange = randomSize();
            centerOffset = new Vector3((PalletSideLength-scaleChange.x)/2, 0, (PalletSideLength-scaleChange.z)/2);
            box = Instantiate(BasicBox, transform.position + centerOffset, Quaternion.identity);
            box.transform.localScale += scaleChange;
            box.GetComponent<movement>().enabled = true;
            restartingPosition = box.transform.position;
            BoxFalling = true;
        }
        if (box.GetComponent<collisions>().canFall) {
            BoxFalling = false;
        }
        if (box.GetComponent<collisions>().reset) {
            resetBox();
        }
    }
}
