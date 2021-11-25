using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractRandomiser : MonoBehaviour
{

    public List<Contract> contractList;
    public Contract[] allContracts;

    public Contract nextRandomContract;

    void Start()
    {
        allContracts = Resources.LoadAll<Contract>("Contracts");

        foreach (Contract c in allContracts)
        {
            Debug.Log("prefab found: " + c.name);
            contractList.Add(c);

        }

        RandomiseContract();

    }  
    
    public void RandomiseContract()
    {
        nextRandomContract = contractList[Random.Range(0, contractList.Count)];
        contractList.Remove(nextRandomContract);
    }
}
