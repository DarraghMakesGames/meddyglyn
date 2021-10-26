using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Contract", menuName = "Contract")]
public class Contract : ScriptableObject
{

    //This ScriptableObject provides the template for creating new contracts

    public string contractName;
    public string description;

    public float targetVolume;
    public float targetSweetness;
    public float targetCitrus;
    public float targetTart;
    public float targetSour;
    public float targetBitter;
    public float targetWoody;
    public float targetPeppery;
    public float targetAge;
    public float targetAlcohol;

}
