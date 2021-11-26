using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractPositionManager : MonoBehaviour
{

    [SerializeField] private Contract contract;
    public InteractionPrompt prompt;

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
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            prompt.interactionText = "Examine Contract";
        }
    }

}
