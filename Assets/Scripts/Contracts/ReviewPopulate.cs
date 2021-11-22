using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReviewPopulate : MonoBehaviour
{

    [SerializeField] private Contract contract;

    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text descriptionText;

    private void Update()
    {
        contract = GetComponentInParent<MasterTracker>().contract;
        nameText.text = contract.contractName;
        descriptionText.text = contract.description;

    }

}
