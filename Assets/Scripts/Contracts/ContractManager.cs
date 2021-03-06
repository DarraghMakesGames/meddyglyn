using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractManager : MonoBehaviour
{

    public static Contract currentContract;

    public static Contract contract1 = null;
    public static Contract contract2 = null;
    public static Contract contract3 = null;

    public static bool contract1filled = false;
    public static bool contract2filled = false;
    public static bool contract3filled = false;
    public static bool allContractsFilled = false;

    [SerializeField] private Contract setContract1;
    [SerializeField] private Contract setContract2;
    [SerializeField] private Contract setContract3;

    [SerializeField] private GameObject wagon1;
    [SerializeField] private GameObject wagon2;
    [SerializeField] private GameObject wagon3;

    [SerializeField] private GameObject contractPos1;
    [SerializeField] private GameObject contractPos2;
    [SerializeField] private GameObject contractPos3;

    private Transform contractPos1transform;
    private Transform contractPos2transform;
    private Transform contractPos3transform;

    [SerializeField] private GameObject contractSpawn;

    private void Start()
    {
        contract1 = setContract1;
        contract2 = setContract2;
        contract3 = setContract3;

        contractPos1transform = contractPos1.transform;
        contractPos2transform = contractPos2.transform;
        contractPos3transform = contractPos3.transform;

    }

    private void Update()
    {
        wagon1.GetComponent<MasterTracker>().contract = contract1;
        wagon2.GetComponent<MasterTracker>().contract = contract2;
        wagon3.GetComponent<MasterTracker>().contract = contract3;

        if (contract1filled && contract2filled && contract3filled)
        {
            allContractsFilled = true;
        }
        else
        {
            allContractsFilled = false;
        }

    }

}
