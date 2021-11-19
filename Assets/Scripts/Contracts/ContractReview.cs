using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContractReview : MonoBehaviour
{
    public Contract contract;
    [SerializeField] Contract noContract;

    [SerializeField] private GameObject title;
    [SerializeField] private GameObject description;
    [SerializeField] private GameObject time;
    [SerializeField] private GameObject reward;
    [SerializeField] private GameObject player;

    private void OnEnable()
    {
        contract = GetComponentInParent<ContractFulfilment>().contract;
        title.GetComponent<UnityEngine.UI.Text>().text = contract.contractName;
        description.GetComponent<UnityEngine.UI.Text>().text = contract.description;
        time.GetComponent<UnityEngine.UI.Text>().text = contract.time.ToString();
        reward.GetComponent<UnityEngine.UI.Text>().text = contract.reward.ToString();
    }

    public void SetContract()
    {
        if (ContractManager.contract1filled == false)
        {
            ContractManager.contract1 = contract;
            ContractManager.contract1filled = true;
        }
        else if (ContractManager.contract2filled == false)
        {
            ContractManager.contract2 = contract;
            ContractManager.contract2filled = true;
        }
        else if (ContractManager.contract3filled == false)
        {
            ContractManager.contract3 = contract;
            ContractManager.contract3filled = true;
        }
        else
        {
            Debug.Log("Too many contracts accepted");
        }
    }

    public void Closed()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<PlayerMovement>().enabled = true;
        contract = null;
    }

}
