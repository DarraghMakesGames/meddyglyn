using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteContract : MonoBehaviour
{
    [SerializeField] private GameObject wagon;
    [SerializeField] private Contract contract;
    [SerializeField] GameObject pos1;
    [SerializeField] GameObject pos2;
    [SerializeField] GameObject pos3;
    [SerializeField] GameObject pos4;
    [SerializeField] GameObject pos5;
    [SerializeField] GameObject pos6;
    [SerializeField] GameObject pos7;
    [SerializeField] GameObject pos8;

    [SerializeField] private GameObject GoldCount;

    public void Complete()
    {

        if (wagon.GetComponent<MasterTracker>().allRequirementsMet)
        {
            GoldCount.SendMessage("AddGold", 250);
        }

    }

}
