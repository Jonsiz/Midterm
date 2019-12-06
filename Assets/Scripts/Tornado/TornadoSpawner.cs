using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoSpawner : MonoBehaviour
{
    public GameObject tornadoPrefab;
    public GameObject TornadoTriggerOff;
    private int spawnPosX;
    private int spawnPosZ;

    private void OnTriggerEnter()
    {
        int spawnPosX = Random.Range(-300, 300);
        int spawnPosZ = Random.Range(-200, 300);

        Instantiate(tornadoPrefab, new Vector3(spawnPosX, 0, spawnPosZ), transform.rotation);
    }

    private void OnTriggerExit()
    { 
        TornadoTriggerOff.SetActive(false);
    }

}
