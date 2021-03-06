using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselManager : MonoBehaviour
{

    private GameObject CarriedObject;
    private GameObject carriedObj;
    private Transform carried;

    public int batchNumber;

    [SerializeField] private GameObject cork;
    [SerializeField] private GameObject liquidLevel;
    [SerializeField] private GameObject foam;

    public float honeyAmount;
    public float waterAmount;
    public float sweetnessAmount;
    public float citrusAmount;
    public float tartAmount;
    public float sourAmount;
    public float bitterAmount;
    public float woodyAmount;
    public float pepperyAmount;
    public float floralAmount;
    public float earthyAmount;
    public float greenAmount;

    public float honeyStrength;
    public float sweetnessStrength;
    public float citrusStrength;
    public float tartStrength;
    public float sourStrength;
    public float bitterStrength;
    public float woodyStrength;
    public float pepperyStrength;
    public float floralStrength;
    public float earthyStrength;
    public float greenStrength;

    [SerializeField] private float honeyAdd;
    [SerializeField] private bool isWater;
    [SerializeField] private float waterAdd;
    [SerializeField] private float sweetnessAdd;
    [SerializeField] private float yeastAdd;
    [SerializeField] private float citrusAdd;
    [SerializeField] private float tartAdd;
    [SerializeField] private float sourAdd;
    [SerializeField] private float bitterAdd;
    [SerializeField] private float woodyAdd;
    [SerializeField] private float pepperyAdd;
    [SerializeField] private float floralAdd;
    [SerializeField] private float earthyAdd;
    [SerializeField] private float greenAdd;

    public string sweetnessRating;
    public string alcoholRating;

    public bool hasYeast;
   
    [SerializeField] private bool isStarted;
    public bool isFinished;
    public float alcohol;
    [SerializeField] private int yeastTolerance;
    public float totalLiquidContent;
    public float maxLiquidContent;
    [SerializeField] private float ingredientAmount;
    [SerializeField] private float capacityRemaining;
    public GameObject vesselObj;

    [SerializeField] GameObject examine;

    [SerializeField] private string properties;
    public string citrusProp;
    public string tartProp;
    public string sourProp;
    public string bitterProp;
    public string woodyProp;
    public string pepperyProp;
    public string floralProp;
    public string earthyProp;
    public string greenProp;

    private AudioSource addIngredientSound;


    // Finding the CarriedObject gameObject as a target & defining self as a variable
    void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        vesselObj = this.gameObject;
        addIngredientSound = GetComponent<AudioSource>();
    }

    // When interacted with, this function looks in the player's hand (CarriedObject) for a child (object being carried)
    public void Interacted()
    {
        if (CarriedObject.transform.childCount < 1)
        {
            Debug.Log("Not carrying anything");
        }
        else
        {
            carried = CarriedObject.gameObject.transform.GetChild(0);
            carriedObj = carried.transform.gameObject;

                // If the carried object is of "Ingredient" type, values from that object are added to the vessel and the carried object is destroyed
                
            
            if (carriedObj.gameObject.CompareTag("Ingredient"))
                {
                 
                    

                    ingredientAmount = carriedObj.GetComponent<IngredientValues>().amount;
                    honeyAdd = carriedObj.GetComponent<IngredientValues>().honey;
                    isWater = carriedObj.GetComponent<IngredientValues>().isWater;
                    sweetnessAdd = carriedObj.GetComponent<IngredientValues>().sweetness;
                    yeastAdd = carriedObj.GetComponent<IngredientValues>().yeast;
                    citrusAdd = carriedObj.GetComponent<IngredientValues>().citrus;
                    tartAdd = carriedObj.GetComponent<IngredientValues>().tart;
                    sourAdd = carriedObj.GetComponent<IngredientValues>().sour;
                    bitterAdd = carriedObj.GetComponent<IngredientValues>().bitter;
                    woodyAdd = carriedObj.GetComponent<IngredientValues>().woody;
                    pepperyAdd = carriedObj.GetComponent<IngredientValues>().peppery;
                    floralAdd = carriedObj.GetComponent<IngredientValues>().floral;
                    earthyAdd = carriedObj.GetComponent<IngredientValues>().earthy;
                    greenAdd = carriedObj.GetComponent<IngredientValues>().green;

                //isStarted means fermentation has begun - if it has, the player cannot add ingredients
                if (!isStarted)
                {
                    //Ingredients are only added if there is room in the vessel
                    if (capacityRemaining >= ingredientAmount || yeastAdd > 0)
                    {
                        addIngredientSound.PlayOneShot(addIngredientSound.clip, 1);

                        honeyAmount += honeyAdd;
                        sweetnessAmount += sweetnessAdd;
                        citrusAmount += citrusAdd;

                        tartAmount += tartAdd;

                        sourAmount += sourAdd;

                        bitterAmount += bitterAdd;
 
                        woodyAmount += woodyAdd;

                        pepperyAmount += pepperyAdd;

                        floralAmount += floralAdd;

                        earthyAmount += earthyAdd;

                        greenAmount += greenAdd;

                        totalLiquidContent += ingredientAmount;

                        if (yeastAdd > 0)
                        {
                            hasYeast = true;
                            yeastTolerance = carriedObj.GetComponent<IngredientValues>().yeastTolerance;
                        }

                        if (isWater)
                        {
                            waterAmount = capacityRemaining;
                            totalLiquidContent = maxLiquidContent;
                            capacityRemaining = 0;
                        }

                        honeyStrength = honeyAmount / totalLiquidContent * 100;
                        sweetnessStrength = sweetnessAmount / totalLiquidContent * 100;
                        citrusStrength = citrusAmount / totalLiquidContent * 100;
                        tartStrength = tartAmount / totalLiquidContent * 100;
                        sourStrength = sourAmount / totalLiquidContent * 100;
                        bitterStrength = bitterAmount / totalLiquidContent * 100;
                        woodyStrength = woodyAmount / totalLiquidContent * 100;
                        pepperyStrength = pepperyAmount / totalLiquidContent * 100;
                        floralStrength = floralAmount / totalLiquidContent * 100;
                        earthyStrength = earthyAmount / totalLiquidContent * 100;
                        greenStrength = greenAmount / totalLiquidContent * 100;

                        Destroy(carriedObj);
                    }
                    else
                    {
                        Debug.Log("Not enough room in vessel");

                    }
                }

                else if (isStarted)
                {
                    Debug.Log("Can't add more once ferment starts");
                }

                }


                    // If the carried object is of type "Storage", the following triggers the "Fill" function of the storage object using this object as the parameter
                    else if (carriedObj.gameObject.CompareTag("Storage"))
                        {
                        if (carriedObj.gameObject.GetComponent<StorageManager>().capacity <= totalLiquidContent && isFinished)
                            {
                                Debug.Log("Vessel to fill the bottle");
                                carriedObj.gameObject.SendMessage("Fill", vesselObj);
                                //If transferring to the storage container would fully empty the vessel, this calls the EmptyVessel function to clear values
                                if (totalLiquidContent < 1)
                                {
                                    EmptyVessel();
                                }
                            }

                            else
                            {
                                Debug.Log("Not finished fermenting or not enough to fill container");
                            }
                        
                        }
        }
    }

    private void Update()
    {
        if (totalLiquidContent > 0)
        {
            ExpressValues();
            GetComponent<ExamineItem>().uiProperties = properties;
            liquidLevel.gameObject.SetActive(true);
        }

        capacityRemaining = maxLiquidContent - totalLiquidContent;

        // This code checks if the vessel has both yeast and sweetness - if it does, fermentation begins
        if (hasYeast && honeyAmount > 0 && isStarted == false && totalLiquidContent == maxLiquidContent)
        {
            StartCoroutine("Fermentation");
            isStarted = true;
            cork.SetActive(true);
            foam.SetActive(true);
        }
    }

    //The below coroutine over time converts the sweetness value into alcohol
    IEnumerator Fermentation()
    {
        while (alcohol < yeastTolerance && honeyAmount > 0)
        {
            yield return new WaitForSeconds(5f);
            sweetnessStrength -= 0.5f;
            alcohol ++;
                if (alcohol == yeastTolerance)
            {
                isFinished = true;
                foam.SetActive(false);
                GameManager.batchesMade += 1;
                batchNumber = GameManager.batchNumber;
                GameManager.batchNumber += 1;
                StopCoroutine("Fermentation");
            }
            
        }
    }

    //This resets all variables to their default value - vessel ready for next batch
    public void EmptyVessel()
    {
        honeyAmount = 0;
        waterAmount = 0;
        sweetnessAmount = 0;
        citrusAmount = 0;
        tartAmount = 0;
        sourAmount = 0;
        bitterAmount = 0;
        woodyAmount = 0;
        pepperyAmount = 0;
        floralAmount = 0;
        earthyAmount = 0;
        greenAmount = 0;
        totalLiquidContent = 0;
        yeastAdd = 0;
        hasYeast = false;
        isStarted = false;
        isFinished = false;
        cork.SetActive(false);
        foam.SetActive(false);
        alcohol = 0;
        yeastTolerance = 0;
        ingredientAmount = 0;
        capacityRemaining = maxLiquidContent;
        citrusProp = null;
        tartProp = null;
        sourProp = null;
        bitterProp = null;
        woodyProp = null;
        pepperyProp = null;
        floralProp = null;
        earthyProp = null;
        greenProp = null;
        ExpressValues();
        GetComponent<ExamineItem>().uiProperties = properties;
    }

    public void ExpressValues()
                   {
                        //This expresses the strength of the honey in human-readable terms
                        //0-5 is low, 6-10 is average, 11+ is high

                        if (sweetnessStrength > 0 && sweetnessStrength <= 5)
                        {
                            sweetnessRating = "Low";
                        }
                        else if (sweetnessStrength > 5 && sweetnessStrength < 11)
                        {
                            sweetnessRating = "Average";
                        }
                        else if (sweetnessStrength >= 11)
                        {
                            sweetnessRating = "High";
                        }
                        else if (sweetnessStrength == 0)
                        {
                            sweetnessRating = "None";
                        }

                        //This expresses the strength of the alcohol in human-readable terms
                        //0-5 is low, 6-10 is average, 11+ is high

                        if (alcohol > 0 && alcohol <= 5)
                        {
                            alcoholRating = "Low";
                        }
                        else if (alcohol > 5 && alcohol < 11)
                        {
                            alcoholRating = "Average";
                        }
                        else if (alcohol >= 11)
                        {
                            alcoholRating = "High";
                        }
                        else if (alcohol == 0)
                        {
                            alcoholRating = "None";
                        }

        //The following expresses each flavour's strength in human-readable terms
        //0-5 is low, 6-10 is average, 11+ is high

        if (citrusStrength > 0 && citrusStrength <= 5)
        {
            citrusProp = "Citrus(Subtle) ";
        }
        else if (citrusStrength > 5 && citrusStrength < 11)
        {
            citrusProp = "Citrus(Average) ";
        }
        else if (citrusStrength >= 11)
        {
            citrusProp = "Citrus(Strong) ";
        }
        else if (citrusStrength == 0)
        {
            citrusProp = null;
        }

        if (tartStrength > 0 && tartStrength <= 5)
        {
            tartProp = "Tart(Subtle) ";
        }
        else if (tartStrength > 5 && tartStrength < 11)
        {
            tartProp = "Tart(Average) ";
        }
        else if (tartStrength >= 11)
        {
            tartProp = "Tart(Strong) ";
        }
        else if (tartStrength == 0)
        {
            tartProp = null;
        }

        if (sourStrength > 0 && sourStrength <= 5)
        {
            sourProp = "Sour(Subtle) ";
        }
        else if (sourStrength > 5 && sourStrength < 11)
        {
            sourProp = "Sour(Average) ";
        }
        else if (sourStrength >= 11)
        {
            sourProp = "Sour(Strong) ";
        }
        else if (sourStrength == 0)
        {
            sourProp = null;
        }

        if (woodyStrength > 0 && woodyStrength <= 5)
        {
            woodyProp = "Woody(Subtle) ";
        }
        else if (woodyStrength > 5 && woodyStrength < 11)
        {
            woodyProp = "Woody(Average) ";
        }
        else if (woodyStrength >= 11)
        {
            woodyProp = "Woody(Strong) ";
        }
        else if (woodyStrength == 0)
        {
            woodyProp = null;
        }

        if (pepperyStrength > 0 && pepperyStrength <= 5)
        {
            pepperyProp = "Peppery(Subtle) ";
        }
        else if (pepperyStrength > 5 && pepperyStrength < 11)
        {
            pepperyProp = "Peppery(Average) ";
        }
        else if (pepperyStrength >= 11)
        {
            pepperyProp = "Peppery(Strong) ";
        }
        else if (pepperyStrength == 0)
        {
            pepperyProp = null;
        }

        if (bitterStrength > 0 && bitterStrength <= 5)
        {
            bitterProp = "Bitter(Subtle) ";
        }
        else if (bitterStrength > 5 && bitterStrength < 11)
        {
            bitterProp = "Bitter(Average) ";
        }
        else if (bitterStrength >= 11)
        {
            bitterProp = "Bitter(Strong) ";
        }
        else if (bitterStrength == 0)
        {
            bitterProp = null;
        }

        if (floralStrength > 0 && floralStrength <= 5)
        {
            floralProp = "Floral(Subtle) ";
        }
        else if (floralStrength > 5 && floralStrength < 11)
        {
            floralProp = "Floral(Average) ";
        }
        else if (floralStrength >= 11)
        {
            floralProp = "Floral(Strong) ";
        }
        else if (floralStrength == 0)
        {
            floralProp = null;
        }

        if (earthyStrength > 0 && earthyStrength <= 5)
        {
            earthyProp = "Earthy(Subtle) ";
        }
        else if (earthyStrength > 5 && earthyStrength < 11)
        {
            earthyProp = "Earthy(Average) ";
        }
        else if (earthyStrength >= 11)
        {
            earthyProp = "Earthy(Strong) ";
        }
        else if (earthyStrength == 0)
        {
            earthyProp = null;
        }

        if (greenStrength > 0 && greenStrength <= 5)
        {
            greenProp = "Green(Subtle) ";
        }
        else if (greenStrength > 5 && greenStrength < 11)
        {
            greenProp = "Green(Average) ";
        }
        else if (greenStrength >= 11)
        {
            greenProp = "Green(Strong) ";
        }
        else if (greenStrength == 0)
        {
            greenProp = null;
        }

        //This sets the properties component of the examine UI based on the contents of the vessel
        if (totalLiquidContent == 0)
                            {
                                properties = "Contains: Empty";
                            }
                        else if (totalLiquidContent > 0)
                            {
                                    properties = "Contains: " + totalLiquidContent + "/" + maxLiquidContent + " " + "Honey" + "(" + honeyAmount + "ml" + ") " + "Water" + "(" + waterAmount + "ml" + ") " 
                                    + "Sweetness " + "(" + sweetnessRating + ") " + "Alcohol " + "(" + alcoholRating + ", " + alcohol + "%" + ") "
                                    + citrusProp + tartProp + sourProp + bitterProp + woodyProp + pepperyProp + floralProp + earthyProp + greenProp;
                            }


                }


}
