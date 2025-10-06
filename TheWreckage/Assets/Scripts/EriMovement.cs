using UnityEngine;

public class EriMovement : MonoBehaviour
{
    public GameObject camObj;
    Camera cam;
    void Start()
    {
        cam = camObj.GetComponent<Camera>();
    }


    void Update()
    {
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4));
    }
}
