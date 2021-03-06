using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SuccessPopulate : MonoBehaviour
{
    [SerializeField] private Contract contract;

    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text successText;
    [SerializeField] private TMP_Text rewardSummary;

    private void Update()
    {
        contract = GetComponentInParent<MasterTracker>().contract;
        nameText.text = contract.contractName + ": Success!";
        successText.text = contract.passText;
        rewardSummary.text = "Reward: " + contract.reward.ToString() + "gp" + contract.rewardText;

    }

}
