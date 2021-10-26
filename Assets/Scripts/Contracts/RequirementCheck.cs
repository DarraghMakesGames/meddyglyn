using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequirementCheck : MonoBehaviour
{
    public Contract contract;
    private Transform toBeChecked;

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

    public float actualVolume;
    public float actualSweetness;
    public float actualCitrus;
    public float actualTart;
    public float actualSour;
    public float actualBitter;
    public float actualWoody;
    public float actualPeppery;
    public float actualAge;
    public float actualAlcohol;

    public bool matchesVolume = false;
    public bool matchesSweetness = false;
    public bool matchesCitrus = false;
    public bool matchesTart = false;
    public bool matchesSour = false;
    public bool matchesBitter = false;
    public bool matchesWoody = false;
    public bool matchesPeppery = false;
    public bool matchesAge = false;
    public bool matchesAlcohol = false;


    void Update()
    {

    targetVolume = contract.targetVolume;
    targetSweetness = contract.targetSweetness;
    targetCitrus = contract.targetCitrus;
    targetTart = contract.targetTart;
    targetSour = contract.targetSour;
    targetBitter = contract.targetBitter;
    targetWoody = contract.targetWoody;
    targetPeppery = contract.targetPeppery;
    targetAge = contract.targetAge;
    targetAlcohol = contract.targetAlcohol;

        if (this.gameObject.transform.childCount > 0){
            toBeChecked = this.gameObject.transform.GetChild(0);
            actualVolume = toBeChecked.GetComponent<StorageManager>().capacity;
            actualAlcohol = toBeChecked.GetComponent<StorageManager>().alcohol;
            actualSweetness = toBeChecked.GetComponent<StorageManager>().sweetness;
            actualCitrus = toBeChecked.GetComponent<StorageManager>().citrus;
            actualTart = toBeChecked.GetComponent<StorageManager>().tart;
            actualSour = toBeChecked.GetComponent<StorageManager>().sour;
            actualBitter = toBeChecked.GetComponent<StorageManager>().bitter;
            actualWoody = toBeChecked.GetComponent<StorageManager>().woody;
            actualPeppery = toBeChecked.GetComponent<StorageManager>().peppery;
        }
        else if (this.gameObject.transform.childCount < 1){
            toBeChecked = null;
            actualVolume = 0;
            actualSweetness = 0;
            actualCitrus = 0;
            actualTart = 0;
            actualSour = 0;
            actualBitter = 0;
            actualWoody = 0;
            actualPeppery = 0;
            actualAge = 0;
            actualAlcohol = 0;
}


        if (actualVolume == targetVolume)
        {
            matchesVolume = true;
        }
        else
        {
            matchesVolume = false;
        }

        if (actualSweetness == targetSweetness)
        {
            matchesSweetness = true;
        }
        else
        {
            matchesSweetness = false;
        }

        if (actualCitrus == targetCitrus)
        {
            matchesCitrus = true;
        }
        else
        {
            matchesCitrus = false;
        }

        if (actualTart == targetTart)
        {
            matchesTart = true;
        }
        else
        {
            matchesTart = false;
        }

        if (actualSour == targetSour)
        {
            matchesSour = true;
        }
        else
        {
            matchesSour = false;
        }

        if (actualBitter == targetBitter)
        {
            matchesBitter = true;
        }
        else
        {
            matchesBitter = false;
        }

        if (actualWoody == targetWoody)
        {
            matchesWoody = true;
        }
        else
        {
            matchesWoody = false;
        }

        if (actualPeppery == targetPeppery)
        {
            matchesPeppery = true;
        }
        else
        {
            matchesPeppery = false;
        }



    }
}
