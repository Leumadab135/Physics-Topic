
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool isJumping;

    private void OnCollisionEnter(Collision collision)  
    {
        //Las coliciones son funciones. Puede haber una cuando colisione y otra cuando deje de colisionar

        //Colisión con el game object de tag ball... esta es la forma correcta de detección
        if (collision.gameObject.tag == "Ball")  
            print("Toque");

        if (collision.gameObject.tag == "Floor")
            isJumping = false;  
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJumping = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            print("GOOOOL!!!");
            other.gameObject.SetActive(false);
        }
    }
}
