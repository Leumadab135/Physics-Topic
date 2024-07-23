
using UnityEngine;

public class WindTunel : MonoBehaviour
{
    //Public Attributes
    public float windForce;
    Rigidbody objectIn = null; // Esto se hace con el objetivo de capturar el componente de manera correcta.

    private void OnTriggerStay(Collider other)
    {
        objectIn = other.GetComponent<Rigidbody>();
    }
    
    private void OnTriggerExit(Collider other)
    {
        objectIn = null;
    }
   
    private void FixedUpdate()
    {
        if (objectIn != null)
        {
            objectIn.AddForce(Vector3.up * windForce);
        }
    }
    //Esta es la manera correcta de usar los triggers en el caso de las físicas, ya que usamos cosas para "etiquetar" sucesos y usamos 
    //FixedUpdate en las físicas para evitar cualquier cambio irrealista como una fuerza más suave en caída de FPS.
}
