using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ContractLedger : MonoBehaviour
{

    [SerializeField] private Button contract1Button;
    [SerializeField] private Button contract2Button;
    [SerializeField] private Button contract3Button;
    [SerializeField] private Contract contractToRead;
    public void ShowContract1()
    {
        contract1Button.interactable = false;
        contract2Button.interactable = true;
        contract3Button.interactable = true;
        contractToRead = ContractManager.contract1;
    }

    public void ShowContract2()
    {
        contract1Button.interactable = true;
        contract2Button.interactable = false;
        contract3Button.interactable = true;
        contractToRead = ContractManager.contract2;
    }

    public void ShowContract3()
    {
        contract1Button.interactable = true;
        contract2Button.interactable = true;
        contract3Button.interactable = false;
        contractToRead = ContractManager.contract3;
    }


}
