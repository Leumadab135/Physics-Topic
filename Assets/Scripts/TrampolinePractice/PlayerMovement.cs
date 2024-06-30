
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //EL MOVIMIENTO DE ESTE JUGADOR ESTÁ BASADO EN FÍSICAS

    //Private Attributes
    [SerializeField]
    private Rigidbody playerRigidbody;
    private bool isJumping;
    private float speedMove;
    private float jumpForce = 250;

    //Methods
    private void Start()
    {
        print("Welcome to the Trampoline Area!!! Be free to jump as much as you want");
        print("If you hold Space while jumping in the trampoline, ,you can reach a higher altitude");
    }

    //Floor detection for Jump
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJumping = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Trampoline")
            isJumping = true;
    }

        //W,A,S,D Player Movement 
    private void FixedUpdate()
    {
        playerRigidbody.AddForce(Input.GetAxis("Horizontal") * speedMove, 0, Input.GetAxis("Vertical") * speedMove);
    }
    void Update()
    {
        AirSpeedBalance();
        //Jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
                playerRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
    void AirSpeedBalance () //Makes the movement force weaker in the air to have a balance between ground and air
    {
        if (isJumping == false)
            speedMove = 20f;
        else 
            speedMove = 5f;
    }
}
