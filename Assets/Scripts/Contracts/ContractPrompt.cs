using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContractPrompt : MonoBehaviour
{
    public Contract contract;
    [SerializeField] Contract noContract;

    [SerializeField] private GameObject title;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private GameObject description;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private GameObject reward;
    [SerializeField] private TMP_Text rewardText;
    [SerializeField] private GameObject player;

    public GameObject contractOfferPosition;

    private void OnEnable()
    {

        titleText.text = contract.contractName;

        descriptionText.text = contract.description;

        rewardText.text = contract.reward.ToString() + "gp";
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

    public void ClearContract()
    {
        contractOfferPosition.GetComponent<ReadContract>().contract = null;
    }

    public void Closed()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<PlayerMovement>().enabled = true;
        contract = null;
        contractOfferPosition = null;
    }

}
