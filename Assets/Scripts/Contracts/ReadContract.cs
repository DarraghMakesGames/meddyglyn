using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadContract : MonoBehaviour
{

    public Contract contract;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject contractReadout;
    [SerializeField] private GameObject UI;

    [SerializeField] private GameObject contractManager;

    [SerializeField] private bool getRandom = true;

    IEnumerator GetNewContract()
    {
                int wait = Random.Range(5, 15);
                yield return new WaitForSeconds(wait);
                contract = ContractRandomiser.nextRandomContract;
                getRandom = true;
                contractManager.SendMessage("ContractTaken");
    }

    private void Start()
    {
        contractManager = GameObject.Find("ContractManager");
    }

    public void Interacted()
    {
        contractReadout.GetComponent<ContractPrompt>().contract = contract;
        contractReadout.GetComponent<ContractPrompt>().contractOfferPosition = this.gameObject;
        contractReadout.SetActive(true);
        UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void ClearContract()
    {
        contract = null;
    }

}
