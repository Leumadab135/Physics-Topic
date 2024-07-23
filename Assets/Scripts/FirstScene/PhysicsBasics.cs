
using UnityEngine;

public class PhysicsBasics : MonoBehaviour
{
    //Public Attributes
    public Rigidbody playerRigidbody;
    public Detector detector;
    public float jumpForce;
    public float speedMove;

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && detector.isJumping == false)
        playerRigidbody.AddForce(Vector3.up * jumpForce);
    }

    private void FixedUpdate()
    {
        //Esto genera una fuerza, un movimiento por los ejes X,Z con una velocidad predeterminada.
        playerRigidbody.AddForce(Input.GetAxis("Horizontal") * speedMove,0, Input.GetAxis("Vertical") * speedMove);
    }
}
