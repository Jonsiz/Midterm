using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 40f;
    private float turnSpeed = 65f;
    private float horizontalInput;
    private float fowardInput;
    public bool hasPowerup = false;
    //private Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        //Turning
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //Moving Foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        //playerRb.AddForce(transform.forward * fowardInput * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup_Speed"))
        {
            hasPowerup = true;
            speed += 20f;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
    }
}
