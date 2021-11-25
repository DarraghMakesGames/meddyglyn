using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractRandomiser : MonoBehaviour
{

    public List<Contract> contractList;
    public Contract[] allContracts;

    [SerializeField] private Contract nextContractReadout;

    public static Contract nextRandomContract;

    void Start()
    {
        allContracts = Resources.LoadAll<Contract>("Contracts");

        foreach (Contract c in allContracts)
        {
            Debug.Log("prefab found: " + c.name);
            contractList.Add(c);

        }    

    }

    private void Update()
    {
        nextContractReadout = nextRandomContract;

        if (nextRandomContract == null)
        {
            RandomiseContract();
        }
    }

    public void RandomiseContract()
    {
        nextRandomContract = contractList[Random.Range(0, contractList.Count)];
        contractList.Remove(nextRandomContract);
    }
}
