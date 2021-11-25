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
        if (contractPos1.transform.childCount < 1)
        {
            Instantiate(contractSpawn, contractPos1transform.position, contractPos1transform.rotation, contractPos1transform);
        }
        if (contractPos2.transform.childCount < 1)
        {
            Instantiate(contractSpawn, contractPos2transform.position, contractPos2transform.rotation, contractPos2transform);
        }
        if (contractPos3.transform.childCount < 1)
        {
            Instantiate(contractSpawn, contractPos3transform.position, contractPos3transform.rotation, contractPos3transform);
        }
    }

    private void Update()
    {
        wagon1.GetComponent<MasterTracker>().contract = contract1;
        wagon2.GetComponent<MasterTracker>().contract = contract2;
        wagon3.GetComponent<MasterTracker>().contract = contract3;
    }

}
