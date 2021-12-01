using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractPositionManager : MonoBehaviour
{

    [SerializeField] private Contract contract;
    public InteractionPrompt prompt;
    public GameObject exclamationMark;

    private void Start()
    {
        prompt = GetComponent<InteractionPrompt>();
    }

    private void Update()
    {
        contract = GetComponent<ReadContract>().contract;

        if (contract == null)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            prompt.interactionText = null;
            exclamationMark.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            prompt.interactionText = "Examine Contract";
            if (contract.questContract == true)
            {
                exclamationMark.SetActive(true);
            }
            else
            {
                exclamationMark.SetActive(false);
            }
        }
    }

}
