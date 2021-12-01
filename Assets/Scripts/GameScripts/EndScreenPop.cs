using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenPop : MonoBehaviour
{

    [SerializeField] private TMP_Text batches;
    [SerializeField] private TMP_Text revenue;

    private void OnEnable()
    {
        batches.text = "Batches made: " + GameManager.batchesMade.ToString();
        revenue.text = "Revenue made: " + GameManager.profit.ToString();
    }

}
