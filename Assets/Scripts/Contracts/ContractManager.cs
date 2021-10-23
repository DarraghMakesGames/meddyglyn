using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractManager : MonoBehaviour
{

    [SerializeField] private GameObject contractPos1;
    [SerializeField] private GameObject contractPos2;
    [SerializeField] private GameObject contractPos3;
    private Transform contractPos1transform;
    private Transform contractPos2transform;
    private Transform contractPos3transform;

    [SerializeField] private GameObject contractSpawn;

    private void Start()
    {
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

}
