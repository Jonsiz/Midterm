using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    [SerializeField] GameObject TriggerObject;
    [SerializeField] GameObject TutorialControls;

    private void OnTriggerEnter()
    {
            ShowControls();
    }

    public void ShowControls()
    {
        TutorialControls.SetActive(true);
        StartCoroutine(ControlCountdown());
    }
    public IEnumerator ControlCountdown()
    {
        yield return new WaitForSeconds(7);
        TutorialControls.SetActive(false);
        TriggerObject.SetActive(false);
    }
}
