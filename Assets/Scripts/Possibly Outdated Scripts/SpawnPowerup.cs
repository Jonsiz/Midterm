using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerup : MonoBehaviour
{
    public GameObject[] powerUpPrefab;
    public int powerUpIndex;

    private void OnTriggerEnter()
    {
        Instantiate(powerUpPrefab[powerUpIndex], new Vector3(81, 3, 158), powerUpPrefab[powerUpIndex].transform.rotation);
    }

}
