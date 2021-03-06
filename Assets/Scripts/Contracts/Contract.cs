using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Contract", menuName = "Contract")]
public class Contract : ScriptableObject
{

    //This ScriptableObject provides the template for creating new contracts

    public string contractName;
    public string description;
    public int reward;
    public string rewardText;
    public bool questContract;
    public string questReward;
    

    public string failureText;
    public string passText;

    public float targetVolume;
    public float targetMinSweetness;
    public float targetMaxSweetness;
    public float targetMinCitrus;
    public float targetMaxCitrus;
    public float targetMinTart;
    public float targetMaxTart;
    public float targetMinSour;
    public float targetMaxSour;
    public float targetMinBitter;
    public float targetMaxBitter;
    public float targetMinWoody;
    public float targetMaxWoody;
    public float targetMinPeppery;
    public float targetMaxPeppery;
    public float targetMinFloral;
    public float targetMaxFloral;
    public float targetMinEarthy;
    public float targetMaxEarthy;
    public float targetMinGreen;
    public float targetMaxGreen;
    public float targetMinAge;
    public float targetMinAlcohol;
    public float targetMaxAlcohol;

}
