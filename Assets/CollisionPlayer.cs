using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public PlayerScript player;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle"){
            Debug.Log("HITTED : ");
            player.enabled = false;

        }
    }

    
}
