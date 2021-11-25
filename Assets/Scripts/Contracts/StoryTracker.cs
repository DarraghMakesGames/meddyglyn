using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTracker : MonoBehaviour
{

    public Contract quest1;
    public Contract quest2;
    public Contract quest3;
    public Contract quest4;
    public Contract quest5;
    public Contract quest6;

    public Contract nextContract;

    public int questStage = 1;

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

            default:
                Debug.Log("Quest stage error");
                break;
        }

    }

}