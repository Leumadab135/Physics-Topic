
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up * 100 * Time.deltaTime);
    }

    void FixedUpdate()
    {
        RaycastHit hit; //Esto para guardar información sobre el objeto impactado por el rayo

        //Primero se pasa el punto de origen del Ray y se pone la dirección, en este caso para adelante.
        if (Physics.Raycast(transform.position, transform.forward, out hit)) 
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            //print ("Hit! " + hit.collider.name);
            //print (hit.point);
            //print (hit.normal);
        }
        else
        {
        Debug.DrawRay(transform.position, transform.forward * 5, Color.black);
        }

        if (Physics.SphereCast(transform.position, 1, transform.forward, out hit))
        {
            print("Spherecast detection");
        }
    }
}
