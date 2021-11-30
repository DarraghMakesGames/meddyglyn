using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequirementCheck : MonoBehaviour
{
    public Contract contract;
    private Transform toBeChecked;

    public bool meetsRequirements;

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

    public float actualVolume;
    public float actualSweetness;
    public float actualCitrus;
    public float actualTart;
    public float actualSour;
    public float actualBitter;
    public float actualWoody;
    public float actualPeppery;
    public float actualFloral;
    public float actualEarthy;
    public float actualGreen;
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
    public bool matchesFloral = false;
    public bool matchesEarthy = false;
    public bool matchesGreen = false;
    public bool matchesAge = false;
    public bool matchesAlcohol = false;

    private FailureDescriptionGenerator failureGen;

    private void Start()
    {
        contract = this.transform.GetComponentInParent<MasterTracker>().contract;
        failureGen = this.transform.GetComponentInParent<FailureDescriptionGenerator>();
    }

    public void CheckRequirements()
    {
    contract = this.transform.GetComponentInParent<MasterTracker>().contract;

    targetMinSweetness = contract.targetMinSweetness;
    targetMaxSweetness = contract.targetMaxSweetness;
    targetMinCitrus = contract.targetMinCitrus;
    targetMaxCitrus = contract.targetMaxCitrus;
    targetMinTart = contract.targetMinTart;
    targetMaxTart = contract.targetMaxTart;
    targetMinSour = contract.targetMinSour;
    targetMaxSour = contract.targetMaxSour;
    targetMinBitter = contract.targetMinBitter;
    targetMaxBitter = contract.targetMaxBitter;
    targetMinWoody = contract.targetMinWoody;
    targetMaxWoody = contract.targetMaxWoody;
    targetMinPeppery = contract.targetMinPeppery;
    targetMaxPeppery = contract.targetMaxPeppery;
    targetMinFloral = contract.targetMinFloral;
    targetMaxFloral = contract.targetMaxFloral;
    targetMinEarthy = contract.targetMinEarthy;
    targetMaxEarthy = contract.targetMaxEarthy;
    targetMinGreen = contract.targetMinGreen;
    targetMaxGreen = contract.targetMaxGreen;
    targetMinAge = contract.targetMinAge;
    targetMinAlcohol = contract.targetMinAlcohol;
    targetMaxAlcohol = contract.targetMaxAlcohol;

        if (this.gameObject.transform.childCount > 0){
            toBeChecked = this.gameObject.transform.GetChild(0);
            actualVolume = toBeChecked.GetComponent<StorageManager>().capacity;
            actualAlcohol = toBeChecked.GetComponent<StorageManager>().alcohol;
            actualSweetness = toBeChecked.GetComponent<StorageManager>().sweetness;
            actualAge = toBeChecked.GetComponent<StorageManager>().age;
            actualCitrus = toBeChecked.GetComponent<StorageManager>().citrus;
            actualTart = toBeChecked.GetComponent<StorageManager>().tart;
            actualSour = toBeChecked.GetComponent<StorageManager>().sour;
            actualBitter = toBeChecked.GetComponent<StorageManager>().bitter;
            actualWoody = toBeChecked.GetComponent<StorageManager>().woody;
            actualPeppery = toBeChecked.GetComponent<StorageManager>().peppery;
            actualFloral = toBeChecked.GetComponent<StorageManager>().floral;
            actualEarthy = toBeChecked.GetComponent<StorageManager>().earthy;
            actualGreen = toBeChecked.GetComponent<StorageManager>().green;
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
            actualFloral = 0;
            actualEarthy = 0;
            actualGreen = 0;
            actualAge = 0;
            actualAlcohol = 0;
}
        // Each of the following checks compares the brew being presented versus the contract's requirements.
        // If a requirement is not matched, it calls on the appropriate method in the FailureDescriptionGenerator script
        // This generates a human-readable description of where the brew fell short

        if (this.gameObject.transform.childCount > 0)
        {
            //The following checks the target age against the age of the given batch
            if (actualAge >= targetMinAge)
            {
                matchesAge = true;
            }
            else
            {
                matchesAge = false;
                failureGen.LackAge();
            }


            if (actualSweetness >= targetMinSweetness && actualSweetness <= targetMaxSweetness)
            {
                matchesSweetness = true;
            }
            else if (actualSweetness < targetMinSweetness)
            {
                matchesSweetness = false;
                failureGen.LackSweetness();
            }
            else if (actualSweetness > targetMaxSweetness)
            {
                matchesSweetness = false;
                failureGen.OverSweetness();
            }

            if (actualAlcohol >= targetMinAlcohol && actualAlcohol <= targetMaxAlcohol)
            {
                matchesAlcohol = true;

            }
            else if (actualAlcohol < targetMinAlcohol)
            {
                matchesAlcohol = false;
                failureGen.LackAlcohol();
            }
            else if (actualAlcohol > targetMaxAlcohol)
            {
                matchesAlcohol = false;
                failureGen.OverAlcohol();
            }

            if (actualCitrus >= targetMinCitrus && actualCitrus <= targetMaxCitrus)
            {
                matchesCitrus = true;

            }
            else if (actualCitrus < targetMinCitrus)
            {
                matchesCitrus = false;
                failureGen.LackCitrus();
            }
            else if (actualCitrus > targetMaxCitrus)
            {
                matchesCitrus = false;
                failureGen.OverCitrus();
            }

            if (actualTart >= targetMinTart && actualTart <= targetMaxTart)
            {
                matchesTart = true;

            }
            else if (actualTart < targetMinTart)
            {
                matchesTart = false;
                failureGen.LackTart();
            }
            else if (actualTart > targetMaxTart)
            {
                matchesTart = false;
                failureGen.OverTart();
            }

            if (actualSour >= targetMinSour && actualSour <= targetMaxSour)
            {
                matchesSour = true;

            }
            else if (actualSour < targetMinSour)
            {
                matchesSour = false;
                failureGen.LackSour();
            }
            else if (actualSour > targetMaxSour)
            {
                matchesSour = false;
                failureGen.OverSour();
            }

            if (actualBitter >= targetMinBitter && actualBitter <= targetMaxBitter)
            {
                matchesBitter = true;

            }
            else if (actualBitter < targetMinBitter)
            {
                matchesBitter = false;
                failureGen.LackBitter();
            }
            else if (actualBitter > targetMaxBitter)
            {
                matchesBitter = false;
                failureGen.OverBitter();
            }

            if (actualWoody >= targetMinWoody && actualWoody <= targetMaxWoody)
            {
                matchesWoody = true;

            }
            else if (actualWoody < targetMinWoody)
            {
                matchesWoody = false;
                failureGen.LackWoody();
            }
            else if (actualWoody > targetMaxWoody)
            {
                matchesWoody = false;
                failureGen.OverWoody();
            }

            if (actualPeppery >= targetMinPeppery && actualPeppery <= targetMaxPeppery)
            {
                matchesPeppery = true;

            }
            else if (actualPeppery < targetMinPeppery)
            {
                matchesPeppery = false;
                failureGen.LackPeppery();
            }
            else if (actualPeppery > targetMaxPeppery)
            {
                matchesPeppery = false;
                failureGen.OverPeppery();
            }

            if (actualFloral >= targetMinFloral && actualFloral <= targetMaxFloral)
            {
                matchesFloral = true;

            }
            else if (actualFloral < targetMinFloral)
            {
                matchesFloral = false;
                failureGen.LackFloral();
            }
            else if (actualFloral > targetMaxFloral)
            {
                matchesFloral = false;
                failureGen.OverFloral();
            }

            if (actualEarthy >= targetMinEarthy && actualEarthy <= targetMaxEarthy)
            {
                matchesEarthy = true;

            }
            else if (actualEarthy < targetMinEarthy)
            {
                matchesEarthy = false;
                failureGen.LackEarthy();
            }
            else if (actualEarthy > targetMaxEarthy)
            {
                matchesEarthy = false;
                failureGen.OverEarthy();
            }

            if (actualGreen >= targetMinGreen && actualGreen <= targetMaxGreen)
            {
                matchesGreen = true;

            }
            else if (actualGreen < targetMinGreen)
            {
                matchesGreen = false;
                failureGen.LackGreen();
            }
            else if (actualGreen > targetMaxGreen)
            {
                matchesGreen = false;
                failureGen.OverGreen();
            }
        }




        if (matchesSweetness && matchesAge && matchesAlcohol && matchesCitrus && matchesTart && matchesSour && matchesBitter && matchesWoody && matchesPeppery && matchesFloral && matchesEarthy && matchesGreen || this.gameObject.transform.childCount < 1)
        {
            meetsRequirements = true;
        }
        else 
        {
            meetsRequirements = false;
        }

}
}