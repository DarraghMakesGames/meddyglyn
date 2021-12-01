using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractRandomiser : MonoBehaviour
{

    public List<Contract> contractList;
    //public Contract[] allContracts;

    public Contract[] stage1Contracts;
    public Contract[] stage2Contracts;
    public Contract[] stage3Contracts;

    public bool populate = false;
    public static bool questActive = true;
    [SerializeField] private bool questActiveReadout;

    [SerializeField] private GameObject position1;
    [SerializeField] private GameObject position2;
    [SerializeField] private GameObject position3;


    [SerializeField] private Contract nextContractReadout;

    public static Contract nextRandomContract;

    void Start()
    {
        stage1Contracts = Resources.LoadAll<Contract>("Stage1");

        foreach (Contract c in stage1Contracts)
        {
            Debug.Log("prefab found: " + c.name);
            contractList.Add(c);

        }

        StartCoroutine("TriggerPopulate");

    }

    public void Stage2()
    {
        stage2Contracts = Resources.LoadAll<Contract>("Stage2");

        foreach (Contract c in stage2Contracts)
        {
            Debug.Log("prefab found: " + c.name);
            contractList.Add(c);

        }
    }

    public void Stage3()
    {
        stage3Contracts = Resources.LoadAll<Contract>("Stage3");

        foreach (Contract c in stage3Contracts)
        {
            Debug.Log("prefab found: " + c.name);
            contractList.Add(c);

        }
    }

    private void Update()
    {
        nextContractReadout = nextRandomContract;
        questActiveReadout = questActive;

        if (nextRandomContract == null && populate)
        {
            RandomiseContract();
        }
    }

    public void RandomiseContract()
    {
        nextRandomContract = contractList[Random.Range(0, contractList.Count)];
        contractList.Remove(nextRandomContract);
        Debug.Log("New contract queued!");
    }

    public void ReturnContract(Contract contract)
    {
        contractList.Add(contract);
    }

    public void ContractTaken()
    {
        StartCoroutine("ClearContract");
    }

    private IEnumerator ClearContract()
    {
        yield return new WaitForSeconds(1);
        Debug.Log(nextRandomContract.contractName + " cleared!");
        nextRandomContract = null; 
    }

    private void PopulateBoard()
    {
        if (position1.GetComponent<ReadContract>().contract == null)
        {
            if (questActive == false)
            {
                position1.GetComponent<ReadContract>().contract = StoryTracker.nextContract;
                questActive = true;
                Debug.Log("Quest Contract populated in position 1");
            }
            else
            {
                position1.GetComponent<ReadContract>().contract = nextRandomContract;
                StartCoroutine("ClearContract");
                Debug.Log("Contract populated in position 1");
            }
        }

        else if (position2.GetComponent<ReadContract>().contract == null)
        {
            if (questActive == false)
            {
                position2.GetComponent<ReadContract>().contract = StoryTracker.nextContract;
                questActive = true;
                Debug.Log("Quest Contract populated in position 1");
            }
            else
            {
                position2.GetComponent<ReadContract>().contract = nextRandomContract;
                StartCoroutine("ClearContract");
                Debug.Log("Contract populated in position 2");
            }

        }
        else if (position3.GetComponent<ReadContract>().contract == null)
        {
            if (questActive == false)
            {
                position3.GetComponent<ReadContract>().contract = StoryTracker.nextContract;
                questActive = true;
                Debug.Log("Quest Contract populated in position 3");
            }
            else
            {
                position3.GetComponent<ReadContract>().contract = nextRandomContract;
                StartCoroutine("ClearContract");
                Debug.Log("Contract populated in position 3");
            }
        }
        else
        {
            Debug.Log("Board already full!");
        }
    }

    private IEnumerator TriggerPopulate()
    {
        while (populate)
        {
            yield return new WaitForSeconds(10);
            Debug.Log("Triggering a new populate check");
            PopulateBoard();
        }
        
    }

}
