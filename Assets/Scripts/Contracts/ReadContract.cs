using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadContract : MonoBehaviour
{

    public Contract contract;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject contractReadout;
    [SerializeField] private GameObject UI;

    [SerializeField] private bool getRandom = true;

    IEnumerator GetNewContract()
    {
                int wait = 10;
                //Random.Range(20, 80);
                yield return new WaitForSeconds(wait);
                contract = ContractRandomiser.nextRandomContract;
                getRandom = true;
                //ContractRandomiser.nextRandomContract = null;
    }

    public void Interacted()
    {
        contractReadout.GetComponent<ContractPrompt>().contract = contract;
        contractReadout.SetActive(true);
        UI.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        player.GetComponent<PlayerMovement>().enabled = false;
    }

    private void Update()
    {
        if (contract == null && getRandom == true)
        {
            getRandom = false;
            StartCoroutine("GetNewContract");
        }
    }

}
