using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContractFulfilment : MonoBehaviour
{

    [SerializeField] private Contract contract;
    [SerializeField] private GameObject nameDisplay;
    [SerializeField] private string contractName;

    private void Update()
    {
        contractName = contract.contractName;
        nameDisplay.GetComponent<TMPro.TextMeshPro>().text = contractName;
    }

}
