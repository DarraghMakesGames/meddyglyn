using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FailurePopulator : MonoBehaviour
{

    [SerializeField] private Contract contract;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text failureFlavour;

    private void OnEnable()
    {
        contract = this.gameObject.transform.GetComponentInParent<MasterTracker>().contract;
        nameText.text = contract.contractName;
        failureFlavour.text = contract.failMessage;
    }

}
