using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterTracker : MonoBehaviour
{
    public Contract contract;

    [SerializeField] GameObject pos1;
    [SerializeField] GameObject pos2;
    [SerializeField] GameObject pos3;
    [SerializeField] GameObject pos4;
    [SerializeField] GameObject pos5;
    [SerializeField] GameObject pos6;
    [SerializeField] GameObject pos7;
    [SerializeField] GameObject pos8;

    [SerializeField] private bool pos1Matches;
    [SerializeField] private bool pos2Matches;
    [SerializeField] private bool pos3Matches;
    [SerializeField] private bool pos4Matches;
    [SerializeField] private bool pos5Matches;
    [SerializeField] private bool pos6Matches;
    [SerializeField] private bool pos7Matches;
    [SerializeField] private bool pos8Matches;

    public bool allRequirementsMet;

    public void GetContract()
    {
        contract = ContractManager.currentContract;
    }

    private void Update()
    {
        if (pos1.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos1Matches = true;
        }
        else
        {
            pos1Matches = false;
        }

        if (pos2.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos2Matches = true;
        }
        else
        {
            pos2Matches = false;
        }

        if (pos3.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos3Matches = true;
        }
        else
        {
            pos3Matches = false;
        }

        if (pos4.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos4Matches = true;
        }
        else
        {
            pos4Matches = false;
        }

        if (pos5.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos5Matches = true;
        }
        else
        {
            pos5Matches = false;
        }

        if (pos6.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos6Matches = true;
        }
        else
        {
            pos6Matches = false;
        }

        if (pos7.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos7Matches = true;
        }
        else
        {
            pos7Matches = false;
        }

        if (pos8.GetComponent<RequirementCheck>().meetsRequirements)
        {
            pos8Matches = true;
        }
        else
        {
            pos8Matches = false;
        }

        if (pos1Matches && pos2Matches && pos3Matches && pos4Matches && pos5Matches && pos6Matches && pos7Matches && pos8Matches)
        {
            allRequirementsMet = true;
        }
        else
        {
            allRequirementsMet = false;
        }
    }

}
