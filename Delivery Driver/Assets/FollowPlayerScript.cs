using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour {

    [SerializeField] GameObject player;
    
    private void Update() {
        transform.position = player.transform.position + new Vector3(0, 0, -30);
    }
}
