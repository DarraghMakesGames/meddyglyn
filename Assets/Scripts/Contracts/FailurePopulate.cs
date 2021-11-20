using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FailurePopulate : MonoBehaviour
{
    [SerializeField] private Contract contract;

    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text failureText;
    [SerializeField] private TMP_Text failureSummary;

    private void Update()
    {
        contract = GetComponentInParent<MasterTracker>().contract;
        nameText.text = contract.contractName + ": Failed!";
        failureText.text = contract.failureText;
        failureSummary.text = GetComponentInParent<FailureDescriptionGenerator>().failureDescription;
    }

}
