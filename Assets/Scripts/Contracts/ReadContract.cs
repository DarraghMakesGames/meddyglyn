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
        //contract = GetComponent<ContractFulfilment>().contract;
        contractReadout.GetComponent<ContractReview>().contract = contract;
        contractReadout.SetActive(true);
        UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        player.GetComponent<PlayerMovement>().enabled = false;
    }


}
