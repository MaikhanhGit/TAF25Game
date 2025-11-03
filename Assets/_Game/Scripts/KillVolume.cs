using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {  
        CarController carController = other.attachedRigidbody.
            gameObject.GetComponent<CarController>();


        if (carController != null)
        {
            carController.Die();
        }
    }
}
