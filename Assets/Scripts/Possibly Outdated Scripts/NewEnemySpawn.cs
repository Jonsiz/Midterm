using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemySpawn : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public int carIndex;

    //Chooses an Enemy from an array and spawns one
    private void OnTriggerEnter()
    {
        Instantiate(carPrefabs[carIndex], new Vector3(194, 2, -14), carPrefabs[carIndex].transform.rotation);
    }
} 
