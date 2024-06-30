
using UnityEngine;

public class TrampolineAction : MonoBehaviour
{
    //Private Attributes
    private float springForce;
    private Rigidbody objectIn = null;
    

    private void OnTriggerEnter(Collider other)
    {
        objectIn = other.GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        objectIn = null;
    }

    private void Update()
    {
        //Increase the altitude while jumping in trampoline
        if (Input.GetKey(KeyCode.Space))
            springForce = 300;
        else
            springForce = 200;
    }
    void FixedUpdate()
    {
        if(objectIn != null)
          objectIn.AddForce(Vector3.up * springForce);
    }
}
