using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadContract : MonoBehaviour
{

    public Contract contract;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject contractReadout;
    [SerializeField] private GameObject UI;

    public void Interacted()
    {
        if (contract != null)
        {
            contractReadout.GetComponent<ContractPrompt>().contract = contract;
            contractReadout.GetComponent<ContractPrompt>().contractOfferPosition = this.gameObject;
            contractReadout.SetActive(true);
            UI.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            player.GetComponent<PlayerMovement>().enabled = false;
        }

    }

    public void ClearContract()
    {
        contract = null;
    }


}
