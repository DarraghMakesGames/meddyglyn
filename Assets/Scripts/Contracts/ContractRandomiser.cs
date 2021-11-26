using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractRandomiser : MonoBehaviour
{

    public List<Contract> contractList;
    public Contract[] allContracts;

    public bool populate = false;
    public static bool questActive;
    [SerializeField] private bool questActiveReadout;

    [SerializeField] private GameObject position1;
    [SerializeField] private GameObject position2;
    [SerializeField] private GameObject position3;


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

        StartCoroutine("TriggerPopulate");

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
