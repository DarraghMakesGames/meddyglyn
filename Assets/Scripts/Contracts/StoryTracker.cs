using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StoryTracker : MonoBehaviour
{

    public Contract quest1;
    public Contract quest2;
    public Contract quest3;
    public Contract quest4;
    public Contract quest5;
    public Contract quest6;
    public Contract quest7;
    public Contract quest8;

    [SerializeField] private ContractRandomiser randomiser;

    [SerializeField] private UnityEvent Tutorial;
    [SerializeField] private UnityEvent GoodGraces;
    [SerializeField] private UnityEvent Spice;
    [SerializeField] private UnityEvent ForWantOfAnAle;
    [SerializeField] private UnityEvent HerbLife;

    public static Contract nextContract;
    [SerializeField] private Contract nextContractReadout;

    public static int questStage = 1;
    [SerializeField] private int questStageReadout;

    private void Start()
    {
        randomiser = GetComponent<ContractRandomiser>();
    }

    private void Update()
    {
        switch (questStage)
        {
            case 1:
                nextContract = quest1;
                break;
            case 2:
                nextContract = quest2;
                break;
            case 3:
                nextContract = quest3;
                break;
            case 4:
                nextContract = quest4;
                break;
            case 5:
                nextContract = quest5;
                break;
            case 6:
                nextContract = quest6;
                break;
            case 7:
                nextContract = quest7;
                break;
            case 8:
                nextContract = quest8;
                break;

            default:
                Debug.Log("Quest stage error");
                break;
        }

        nextContractReadout = nextContract;
        questStageReadout = questStage;

    }

    public void TutorialCompleted()
    {
        Tutorial.Invoke();
        randomiser.populate = true;
        randomiser.StartCoroutine("TriggerPopulate");
    }

    public void InGoodGraces()
    {
        GoodGraces.Invoke();
    }

    public void SpiceMerchant()
    {
        Spice.Invoke();
    }

    public void GuardCaptain()
    {
        ForWantOfAnAle.Invoke();
    }

    public void HighSpirits()
    {
        HerbLife.Invoke();
    }

}
