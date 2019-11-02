using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody enemyRb;
    private GameObject player;


    // Establishes a method of calling the rigid body on enemies. Finds the players rigidbody.
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Calculates the distance between the player and the enemies, removes this distance.
    void Update()
    {
        Vector3 Difference = player.transform.position - transform.position;
        Vector3 Force = Difference.normalized * speed;
        enemyRb.AddForce(Force,ForceMode.Impulse);
    }
}
