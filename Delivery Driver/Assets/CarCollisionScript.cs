using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisionScript : MonoBehaviour {

    private int packagesDelivered;
    private bool hasPackage = false;
    
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Car hit something");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        string tag = other.tag;
        if (tag == "Package" && !hasPackage) {
            Destroy(other.gameObject);
            hasPackage = true;
        }

        if (tag == "Customer") {
            if (hasPackage) {
                hasPackage = false;
                packagesDelivered++;
                Debug.Log("Thanks");
                Debug.Log("Delivered: " + packagesDelivered);
                return;
            }
            Debug.Log("Where is my package");
        }
    }

}
