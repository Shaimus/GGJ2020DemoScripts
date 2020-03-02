using UnityEngine;

public class CameraController : MonoBehaviour
{

 
    public float border = 10f;
    public float camSpeed = 8f;
    public Vector2 camLimit; 


    void Update()
    {

        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - border)
        {
            pos.z += camSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= border)
        {
            pos.z -= camSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - border)
        {
            pos.x += camSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= border)
        {
            pos.x -= camSpeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, -camLimit.x, camLimit.x);
        pos.z = Mathf.Clamp(pos.z, -camLimit.y, camLimit.y);

        transform.position = pos;   
        
    }
}
