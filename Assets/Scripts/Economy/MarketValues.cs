using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketValues : MonoBehaviour
{
    [SerializeField] private GameObject marketNotification;

    public static float honeyValue;
    public static float sweetnessValue;
    public static float strengthValue;
    public static float ageValue;
    public static float citrusValue;
    public static float tartValue;
    public static float sourValue;
    public static float bitterValue;
    public static float woodyValue;
    public static float pepperyValue;
    public static float floralValue;
    public static float earthyValue;
    public static float greenValue;
    private bool marketRandom;

    private float preferredFlavour;
    public int preferredSelector;
    private float unpopularFlavour;
    public int unpopularSelector;

    public static string preferredFlavourName = "Citrus";
    public static string unpopularFlavourName = "Bitter";

    [SerializeField] private float marketInterval = 15f;


    private void Start()
    {
        citrusValue = 1f;
        tartValue = 1f;
        sourValue = 1f;
        bitterValue = 1f;
        woodyValue = 1f;
        pepperyValue = 1f;
        floralValue = 1f;
        earthyValue = 1f;
        greenValue = 1f;
        preferredFlavour = 2f;
        unpopularFlavour = 0.1f;
        marketRandom = true;
        StartCoroutine("MarketForces");
    }

    IEnumerator MarketForces()
    {
        while (marketRandom)
        {
            yield return new WaitForSeconds(marketInterval);

            marketNotification.SetActive(true);

            sweetnessValue = Random.Range(0.5f, 2f);
            strengthValue = Random.Range(0.5f, 2f);
            ageValue = Random.Range(1f, 1.5f);

            //Values are reset to default
            citrusValue = 1f;
            tartValue = 1f;
            sourValue = 1f;
            bitterValue = 1f;
            woodyValue = 1f;
            pepperyValue = 1f;
            floralValue = 1f;
            earthyValue = 1f;
            greenValue = 1f;

            //The following randomly selects a flavour as "Preferred" and another as "Unpopular"

            preferredSelector = Random.Range(1, 9);
            unpopularSelector = Random.Range(1, 9);

                //This ensures the same flavour is not chosen for both
                while (unpopularSelector == preferredSelector)
            {
                unpopularSelector = Random.Range(1, 9);
            }

                //Preferred flavour assignment
                if (preferredSelector == 1)
            {
                citrusValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Citrus");
                preferredFlavourName = "Citrus";
            }
                else if (preferredSelector == 2)
            {
                tartValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Tart");
                preferredFlavourName = "Tart";
            }
                else if (preferredSelector == 3)
            {
                sourValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Sour");
                preferredFlavourName = "Sour";
            }
                else if (preferredSelector == 4)
            {
                bitterValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Bitter");
                preferredFlavourName = "Bitter";
            }
                else if (preferredSelector == 5)
            {
                woodyValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Woody");
                preferredFlavourName = "Woody";
            }
                else if (preferredSelector == 6)
            {
                pepperyValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Peppery");
                preferredFlavourName = "Peppery";
            }
                else if (preferredSelector == 7)
            {
                floralValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Floral");
                preferredFlavourName = "Floral";
            }
                else if (preferredSelector == 8)
            {
                earthyValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Earthy");
                preferredFlavourName = "Earthy";
            }
                else if (preferredSelector == 9)
            {
                greenValue = preferredFlavour;
                Debug.Log("Preferred Flavour: Green");
                preferredFlavourName = "Green";
            }
            else
            {
                Debug.Log("Preferred flavour error");
                preferredFlavourName = "Null";
            }


            //Unpopular flavour assignment
            if (unpopularSelector == 1)
            {
                citrusValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Citrus");
                unpopularFlavourName = "Citrus";
            }
            else if (unpopularSelector == 2)
            {
                tartValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Tart");
                unpopularFlavourName = "Tart";
            }
            else if (unpopularSelector == 3)
            {
                sourValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Sour");
                unpopularFlavourName = "Sour";
            }
            else if (unpopularSelector == 4)
            {
                bitterValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Bitter");
                unpopularFlavourName = "Bitter";
            }
            else if (unpopularSelector == 5)
            {
                woodyValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Woody");
                unpopularFlavourName = "Woody";
            }
            else if (unpopularSelector == 6)
            {
                pepperyValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Peppery");
                unpopularFlavourName = "Peppery";
            }
            else if (unpopularSelector == 7)
            {
                floralValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Floral");
                unpopularFlavourName = "Floral";
            }
            else if (unpopularSelector == 8)
            {
                earthyValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Earthy");
                unpopularFlavourName = "Earthy";
            }
            else if (unpopularSelector == 9)
            {
                greenValue = unpopularFlavour;
                Debug.Log("Unpopular Flavour: Green");
                unpopularFlavourName = "Green";
            }
            else
            {
                Debug.Log("Unpopular flavour error");
                unpopularFlavourName = "Null";
            }



        }

    }

}
