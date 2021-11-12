using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateUIName : MonoBehaviour
{

    public Text contractName;

    private void Start()
    {
        contractName = this.GetComponent<Text>();
        contractName.text = "Hello";
    }

}
