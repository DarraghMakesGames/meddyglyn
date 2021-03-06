using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterTracker : MonoBehaviour
{
    public Contract contract;
    [SerializeField] private GameObject goldCount;

    [SerializeField] AudioSource contractSound;

    [SerializeField] private int wagonNumber;
    [SerializeField] private Contract noContract;

    [SerializeField] private GameObject contractManager;
    private FailureDescriptionGenerator failureGen;

    [SerializeField] private GameObject player;

    [SerializeField] GameObject pos1;
    [SerializeField] GameObject pos2;
    [SerializeField] GameObject pos3;
    [SerializeField] GameObject pos4;
    [SerializeField] GameObject pos5;
    [SerializeField] GameObject pos6;
    [SerializeField] GameObject pos7;
    [SerializeField] GameObject pos8;

    [SerializeField] private float targetVolume;
    [SerializeField] private float actualVolume;
    [SerializeField] private bool volumeMatches;

    [SerializeField] private bool pos1Matches;
    [SerializeField] private bool pos2Matches;
    [SerializeField] private bool pos3Matches;
    [SerializeField] private bool pos4Matches;
    [SerializeField] private bool pos5Matches;
    [SerializeField] private bool pos6Matches;
    [SerializeField] private bool pos7Matches;
    [SerializeField] private bool pos8Matches;

    public string failureDescription;
    [SerializeField] private GameObject failurePopup;
    [SerializeField] private GameObject successPopup;

    public bool allRequirementsMet;

    private void Start()
    {
        contractManager = GameObject.Find("ContractManager");
        failureGen = this.transform.GetComponent<FailureDescriptionGenerator>();
        contractSound = this.GetComponent<AudioSource>();
    }

    public void GetContract()
    {
        contract = ContractManager.currentContract;
        contractSound.PlayOneShot(contractSound.clip, 1);
    }

    public void CheckRequirements()
    {
        pos1.SendMessage("CheckRequirements");
        pos2.SendMessage("CheckRequirements");
        pos3.SendMessage("CheckRequirements");
        pos4.SendMessage("CheckRequirements");
        pos5.SendMessage("CheckRequirements");
        pos6.SendMessage("CheckRequirements");
        pos7.SendMessage("CheckRequirements");
        pos8.SendMessage("CheckRequirements");

        targetVolume = contract.targetVolume;
        actualVolume = pos1.GetComponent<RequirementCheck>().actualVolume + pos2.GetComponent<RequirementCheck>().actualVolume + pos4.GetComponent<RequirementCheck>().actualVolume + pos5.GetComponent<RequirementCheck>().actualVolume + pos1.GetComponent<RequirementCheck>().actualVolume + pos6.GetComponent<RequirementCheck>().actualVolume + pos7.GetComponent<RequirementCheck>().actualVolume + pos8.GetComponent<RequirementCheck>().actualVolume;
        if (actualVolume >= targetVolume)
        {
            volumeMatches = true;
        }
        else if (actualVolume < targetVolume)
        {
            volumeMatches = false;
            failureGen.LackVolume();
        }


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

        if (pos1Matches && pos2Matches && pos3Matches && pos4Matches && pos5Matches && pos6Matches && pos7Matches && pos8Matches && volumeMatches)
        {
            allRequirementsMet = true;
        }
        else
        {
            allRequirementsMet = false;
        }
    }

    public void SummaryPopup()
    {
        if (allRequirementsMet == false || pos1.transform.childCount < 1)
        {
            failurePopup.SetActive(true);
        }
        else
        {
            successPopup.SetActive(true);
        }
    }

    public void MarkAsComplete()
    {
        if (contract.questContract == false)
        {
            contractManager.SendMessage("ReturnContract", contract);
        }
            
        CheckRequirements();

        if (allRequirementsMet && pos1.transform.childCount > 0)
        {
            goldCount.SendMessage("AddGold", contract.reward);

            if (contract.questContract == true)
            {
                contractManager.SendMessage(contract.questReward);
                StoryTracker.questStage++;
                ContractRandomiser.questActive = false;
            }

        }
        else if (allRequirementsMet == false && contract.questContract == true)
        {
            ContractRandomiser.questActive = false;
        }

        if (wagonNumber == 1)
        {
            ContractManager.contract1 = noContract;
            ContractManager.contract1filled = false;
        }
        if (wagonNumber == 2)
        {
            ContractManager.contract2 = noContract;
            ContractManager.contract2filled = false;
        }
        if (wagonNumber == 3)
        {
            ContractManager.contract3 = noContract;
            ContractManager.contract3filled = false;
        }

        if (pos1.gameObject.transform.childCount > 0)
        {
            Destroy(pos1.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos2.gameObject.transform.childCount > 0)
        {
            Destroy(pos2.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos3.gameObject.transform.childCount > 0)
        {
            Destroy(pos3.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos4.gameObject.transform.childCount > 0)
        {
            Destroy(pos4.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos5.gameObject.transform.childCount > 0)
        {
            Destroy(pos5.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos6.gameObject.transform.childCount > 0)
        {
            Destroy(pos6.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos7.gameObject.transform.childCount > 0)
        {
            Destroy(pos7.gameObject.transform.GetChild(0).gameObject);
        }
        if (pos8.gameObject.transform.childCount > 0)
        {
            Destroy(pos8.gameObject.transform.GetChild(0).gameObject);
        }

        actualVolume = 0;
    }

}
