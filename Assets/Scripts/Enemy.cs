using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody enemyRb;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Difference = player.transform.position - transform.position;
        Vector3 Force = Difference.normalized * speed;
        enemyRb.AddForce(Force,ForceMode.Impulse);
    }
}
