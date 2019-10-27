using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemySpawn : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public int carIndex;

    private void OnTriggerEnter()
    {
        Instantiate(carPrefabs[carIndex], new Vector3(197, 4, 43), carPrefabs[carIndex].transform.rotation);
    }
} 
