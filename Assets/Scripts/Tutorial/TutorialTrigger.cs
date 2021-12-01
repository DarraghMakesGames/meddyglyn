using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutorialTrigger : MonoBehaviour
{

    [SerializeField] private Tutorial tutorial;
    [SerializeField] private GameObject tutorialPopup;
    [SerializeField] private UnityEvent triggerTutorial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerTutorial.Invoke();
            tutorialPopup.SetActive(true);
            tutorialPopup.SendMessage("Populate", tutorial);
            Debug.Log("Tutorial triggered: " + tutorial.tutorialName);
            Destroy(this.gameObject);
        }
    }

}
