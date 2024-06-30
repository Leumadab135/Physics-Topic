
using UnityEngine;

public class CameraMouseRaycast : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate() //Todo en fixedUpdate porque los raycast son f�sicas.
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Un ray es como un vector drawLine, solo que esto es m�s simplificado
       
        if(Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(GetComponent<Camera>().transform.position, hit.point, Color.blue);
        }
    }
}
