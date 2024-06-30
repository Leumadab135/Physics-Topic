
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDetectorPrueba : MonoBehaviour
{
    private float explosionForce = 2000f;
    private List<Rigidbody> victimsInRange = new List<Rigidbody>();

    private void Update()
    {
        // Detectar el clic del ratón
        if (Input.GetMouseButtonDown(0))
        {
            ApplyExplosionForce();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Añadir a la lista si el objeto tiene la etiqueta "Victim"
        if (other.CompareTag("Victim"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null && !victimsInRange.Contains(rb))
            {
                victimsInRange.Add(rb);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Eliminar de la lista cuando el objeto sale del rango
        if (other.CompareTag("Victim"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null && victimsInRange.Contains(rb))
            {
                victimsInRange.Remove(rb);
            }
        }
    }

    private void ApplyExplosionForce()
    {
        foreach (Rigidbody rb in victimsInRange)
        {
            if (rb != null)
            {
                Vector3 direction = rb.transform.position - transform.position;
                direction.Normalize();
                rb.AddForce(direction * explosionForce);
            }
        }

        // Desactivar el objeto que tiene este script adjunto
        gameObject.SetActive(false);
    }
}


