using UnityEngine;

public class CmeraController : MonoBehaviour
{
    
   public float panSpeed = 30f;
   public float panBorderThickness = 10f;
   public float scrollSpeed = 5f;
   public float min = 10f;
   public float max = 80f;
   private bool doMovement;
    void Update()
    {
        if (Input.GetKey("z"))
        {
            doMovement = !doMovement;
        }
        if (doMovement)
        {
            return;
        }
       if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
       {
        transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
       }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll* 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, min, max);
        transform.position = pos;

    }
}
