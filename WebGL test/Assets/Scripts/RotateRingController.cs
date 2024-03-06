using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float a = 10f;
    public float b = 0.4f;
    public Camera cam;

    public void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * a;
        float rotY = Input.GetAxis("Mouse Y") * a;

        Vector3 right = Vector3.Cross(cam.transform.up, transform.position - cam.transform.position);
        Vector3 up = Vector3.Cross(transform.position - cam.transform.position, right);

        transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
        transform.rotation = Quaternion.AngleAxis(rotY, right) * transform.rotation;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            Debug.Log("Touching in: " + touch.position);
            Ray camRay = cam.ScreenPointToRay (touch.position);
            RaycastHit hit;
            if (Physics.Raycast (camRay, out hit, 10))
            {
                if(touch.phase == TouchPhase.Began)
                {
                    Debug.Log("Touch phase began at: " + touch.position);
                }
                else if(touch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(touch.deltaPosition.y * b, -touch.deltaPosition.x * b, 0, Space.World);
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    Debug.Log("Touch phase ended.");
                }
            }
        }
    }
}
