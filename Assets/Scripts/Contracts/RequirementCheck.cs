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

    [SerializeField] private string lackVolume;
    [SerializeField] private string lackSweetness;
    [SerializeField] private string overSweetness;
    [SerializeField] private string lackCitrus;
    [SerializeField] private string overCitrus;
    [SerializeField] private string lackTart;
    [SerializeField] private string overTart;
    [SerializeField] private string lackSour;
    [SerializeField] private string overSour;
    [SerializeField] private string lackBitter;
    [SerializeField] private string overBitter;
    [SerializeField] private string lackWoody;
    [SerializeField] private string overWoody;
    [SerializeField] private string lackPeppery;
    [SerializeField] private string overPeppery;
    [SerializeField] private string lackFloral;
    [SerializeField] private string overFloral;
    [SerializeField] private string lackEarthy;
    [SerializeField] private string overEarthy;
    [SerializeField] private string lackGreen;
    [SerializeField] private string overGreen;
    [SerializeField] private string lackAge;
    [SerializeField] private string lackAlcohol;
    [SerializeField] private string overAlcohol;

    public string shortcomingDescription;

    private void Start()
    {
        contract = this.transform.GetComponentInParent<MasterTracker>().contract;
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
        //Each of the following checks compares the brew being presented versus the contract's requirements.
        // If a requirement is not matched, the script populates the relevant string describing why.

        //The following checks the target volume against the volume of the given batch
        if (actualVolume >= targetVolume)
        {
            matchesVolume = true;
            lackVolume = null;
        }
        else
        {
            matchesVolume = false;
            lackVolume = " You didn't make enough! ";
        }

        //The following checks the target age against the age of the given batch
        if (actualAge >= targetMinAge)
        {
            matchesAge = true;
            lackAge = null;
        }
        else
        {
            matchesAge = false;
            lackAge = " This wasn't aged for long enough. ";
        }


        if (actualSweetness >= targetMinSweetness && actualSweetness <= targetMaxSweetness)
        {
            matchesSweetness = true;
            lackSweetness = null;
            overSweetness = null;
        }
        else if (actualSweetness < targetMinSweetness)
        {
            matchesSweetness = false;
            overSweetness = null;
            lackSweetness = " It isn't sweet enough. ";
        }
        else if (actualSweetness > targetMaxSweetness)
        {
            matchesSweetness = false;
            lackSweetness = null;
            overSweetness = " It's too sweet. ";
        }

        if (actualAlcohol >= targetMinAlcohol && actualAlcohol <= targetMaxAlcohol)
        {
            matchesAlcohol = true;
            lackAlcohol = null;
            overAlcohol = null;
        }
        else if (actualAlcohol < targetMinAlcohol)
        {
            matchesAlcohol = false;
            lackAlcohol = " The alcohol content isn't high enough. ";
            overAlcohol = null;
        }
        else if (actualAlcohol > targetMaxAlcohol)
        {
            matchesAlcohol = false;
            lackAlcohol = null;
            overAlcohol = " The alcohol content is unpleasantly high. ";
        }

        if (actualCitrus >= targetMinCitrus && actualCitrus <= targetMaxCitrus)
        {
            matchesCitrus = true;
            lackCitrus = null;
            overCitrus = null;
        }
        else if (actualCitrus < targetMinCitrus)
        {
            matchesCitrus = false;
            overCitrus = null;
            lackCitrus = " There's not enough Citrus flavour. ";
        }
        else if (actualCitrus > targetMaxCitrus)
        {
            matchesCitrus = false;
            lackCitrus = null;
            overCitrus = " The Citrus flavour is too strong. ";
        }

        if (actualTart >= targetMinTart && actualTart <= targetMaxTart)
        {
            matchesTart = true;
            lackTart = null;
            overTart = null;
        }
        else if (actualTart < targetMinTart)
        {
            matchesTart = false;
            overTart = null;
            lackTart = " There's not enough Tart flavour. ";
        }
        else if (actualTart > targetMaxTart)
        {
            matchesTart = false;
            lackTart = null;
            overTart = " The Tart flavour is too strong. ";
        }

        if (actualSour >= targetMinSour && actualSour <= targetMaxSour)
        {
            matchesSour = true;
            lackSour = null;
            overSour = null;
        }
        else if (actualSour < targetMinSour)
        {
            matchesSour = false;
            overSour = null;
            lackSour = " There's not enough Sour flavour. ";
        }
        else if (actualSour > targetMaxSour)
        {
            matchesSour = false;
            lackSour = null;
            overSour = " The Sour flavour is too strong. ";
        }

        if (actualBitter >= targetMinBitter && actualBitter <= targetMaxBitter)
        {
            matchesBitter = true;
            lackBitter = null;
            overBitter = null;
        }
        else if (actualBitter < targetMinBitter)
        {
            matchesBitter = false;
            overBitter = null;
            lackBitter = " There's not enough Bitter flavour. ";
        }
        else if (actualBitter > targetMaxBitter)
        {
            matchesBitter = false;
            lackBitter = null;
            overBitter = " The Bitter flavour is too strong. ";
        }

        if (actualWoody >= targetMinWoody && actualWoody <= targetMaxWoody)
        {
            matchesWoody = true;
            lackWoody = null;
            overWoody = null;
        }
        else if (actualWoody < targetMinWoody)
        {
            matchesWoody = false;
            overWoody = null;
            lackWoody = " There's not enough Woody flavour. ";
        }
        else if (actualWoody > targetMaxWoody)
        {
            matchesWoody = false;
            lackWoody = null;
            overWoody = " The Woody flavour is too strong. ";
        }

        if (actualPeppery >= targetMinPeppery && actualPeppery <= targetMaxPeppery)
        {
            matchesPeppery = true;
            lackPeppery = null;
            overPeppery = null;
        }
        else if (actualPeppery < targetMinPeppery)
        {
            matchesPeppery = false;
            overPeppery = null;
            lackPeppery = " There's not enough Peppery flavour. ";
        }
        else if (actualPeppery > targetMaxPeppery)
        {
            matchesPeppery = false;
            lackPeppery = null;
            overPeppery = " The Peppery flavour is too strong. ";
        }

        if (actualFloral >= targetMinFloral && actualFloral <= targetMaxFloral)
        {
            matchesFloral = true;
            lackFloral = null;
            overFloral = null;
        }
        else if (actualFloral < targetMinFloral)
        {
            matchesFloral = false;
            overFloral = null;
            lackFloral = " There's not enough Floral flavour. ";
        }
        else if (actualFloral > targetMaxFloral)
        {
            matchesFloral = false;
            lackFloral = null;
            overFloral = " The Floral flavour is too strong. ";
        }

        if (actualEarthy >= targetMinEarthy && actualEarthy <= targetMaxEarthy)
        {
            matchesEarthy = true;
            lackEarthy = null;
            overEarthy = null;
        }
        else if (actualEarthy < targetMinEarthy)
        {
            matchesEarthy = false;
            overEarthy = null;
            lackEarthy = " There's not enough Earthy flavour. ";
        }
        else if (actualEarthy > targetMaxEarthy)
        {
            matchesEarthy = false;
            lackEarthy = null;
            overEarthy = " The Earthy flavour is too strong. ";
        }

        if (actualGreen >= targetMinGreen && actualGreen <= targetMaxGreen)
        {
            matchesGreen = true;
            lackGreen = null;
            overGreen = null;
        }
        else if (actualGreen < targetMinGreen)
        {
            matchesGreen = false;
            overGreen = null;
            lackGreen = " There's not enough Green flavour. ";
        }
        else if (actualGreen > targetMaxGreen)
        {
            matchesGreen = false;
            lackGreen = null;
            overGreen = " The Green flavour is too strong. ";
        }

        //All of the above strings are concatenated as a description of where the brew falls short of the contract (if applicable)
        shortcomingDescription = lackVolume + lackAge + lackAlcohol + overAlcohol + lackSweetness + overSweetness + lackCitrus + overCitrus + lackTart + overTart + lackSour + overSour + lackBitter + overBitter + lackWoody + overWoody + lackPeppery + overPeppery + lackFloral + overFloral + lackEarthy + overEarthy + lackGreen + overGreen;

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