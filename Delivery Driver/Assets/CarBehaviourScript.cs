using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviourScript : MonoBehaviour {

    [SerializeField] private float steerSpeed = 150f;

    [SerializeField] private float moveSpeed = 10f;
    
    private void Start() {
        
    }

    private void Update() {
        float steerAmount = Input.GetAxis("Horizontal");
        float moveAmount = Input.GetAxis("Vertical");
        float deltaTime = Time.deltaTime;
        transform.Rotate(0, 0, - steerAmount * steerSpeed * deltaTime);
        transform.Translate(0, moveAmount * moveSpeed * deltaTime, 0);
    }
}
