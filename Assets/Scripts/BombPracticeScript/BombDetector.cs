//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BombDetector : MonoBehaviour
//{
//    //Private Attributes
//    private float explosionForce = 2000;
//    private Vector3 vectorDirection;

//    private void OnTriggerEnter(Collider other)
//    {
//        if(other.tag == "Victim")
//        {
//            if (Input.GetMouseButtonDown(0))
//            {
//                vectorDirection = other.transform.position - gameObject.transform.position;
//                vectorDirection.Normalize();

//                gameObject.SetActive(false);
//                other.GetComponent<Rigidbody>().AddForce(vectorDirection * explosionForce);
//            }
//        }

//    }

//}
