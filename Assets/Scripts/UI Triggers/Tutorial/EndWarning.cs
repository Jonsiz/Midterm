using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWarning : MonoBehaviour
{
    [SerializeField] GameObject SelfTrigger;
    [SerializeField] GameObject LapTrigger;

    private void OnTriggerEnter()
    {
        LapTrigger.SetActive(true);
        StartCoroutine(Warning());

    }

    public IEnumerator Warning()
    {
        yield return new WaitForSeconds(5);
        SelfTrigger.SetActive(false);
        LapTrigger.SetActive(false);
    }
}
