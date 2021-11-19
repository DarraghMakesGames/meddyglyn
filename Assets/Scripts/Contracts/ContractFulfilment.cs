using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContractFulfilment : MonoBehaviour
{

    [SerializeField] public Contract contract;
    [SerializeField] private string contractName;
    [SerializeField] private TMP_Text nameText;

    private void Update()
    {
        contract = this.gameObject.transform.GetComponentInParent<MasterTracker>().contract;
        nameText.text = contract.contractName;
    }

}
