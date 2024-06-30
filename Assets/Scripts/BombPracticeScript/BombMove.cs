using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMove : MonoBehaviour
{
    //Private Attributes
    [SerializeField]
    private Rigidbody bombRigidBody;
    private float bombSpeedMove = 10;
    private void Start()
    {
        print("Press LeftClick in order to active the Bomb.");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bombRigidBody.AddForce(Input.GetAxis("Horizontal") * bombSpeedMove, 0, Input.GetAxis("Vertical") * bombSpeedMove);
    }


}
