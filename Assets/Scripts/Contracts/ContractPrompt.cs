using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContractPrompt : MonoBehaviour
{
    public Contract contract;

    [SerializeField] private GameObject title;
    [SerializeField] private GameObject description;
    [SerializeField] private GameObject time;
    [SerializeField] private GameObject reward;

    private void Start()
    {
        title.GetComponent<UnityEngine.UI.Text>().text = contract.contractName;
        description.GetComponent<UnityEngine.UI.Text>().text = contract.description;
        time.GetComponent<UnityEngine.UI.Text>().text = contract.time.ToString();
        reward.GetComponent<UnityEngine.UI.Text>().text = contract.reward.ToString();
    }

}
