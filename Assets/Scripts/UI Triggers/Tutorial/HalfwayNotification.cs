using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HalfwayNotification : MonoBehaviour
{
    [SerializeField] GameObject TriggeringObject;
    [SerializeField] GameObject TutorialCheckpoint;
    [SerializeField] GameObject endTrigger;


    private void OnTriggerEnter()
    {
        TutorialCheckpoint.SetActive(true);
        StartCoroutine(HalfwayCountdown());
    }
    
   public IEnumerator HalfwayCountdown()
    {
        yield return new WaitForSeconds(10);
        TutorialCheckpoint.SetActive(false);
        TriggeringObject.SetActive(false);
        endTrigger.SetActive(true);
    }
}
