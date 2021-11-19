using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailureDescriptionGenerator : MonoBehaviour
{

    [SerializeField] private string lackVolume;
    [SerializeField] private string lackAge;
    [SerializeField] private string lackSweetness;
    [SerializeField] private string overSweetness;
    [SerializeField] private string lackAlcohol;
    [SerializeField] private string overAlcohol;

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

    public string failureDescription;

    public void LackVolume()
    {
        lackVolume = "You didn't make enough! ";
    }
    public void LackAge()
    {
        lackAge = "You didn't age it for long enough. ";
    }
    public void LackSweetness()
    {
        lackSweetness = "It isn't sweet enough. ";
    }
    public void OverSweetness()
    {
        overSweetness = "It's too sweet. ";
    }
    public void LackAlcohol()
    {
        lackAlcohol = "The alcohol content is too low. ";
    }
    public void OverAlcohol()
    {
        overAlcohol = "The alcohol content is too high. ";
    }
    public void LackCitrus()
    {
        lackCitrus = "There isn't enough Citrus flavour. ";
    }
    public void OverCitrus()
    {
        overCitrus = "There's too much Citrus flavour. ";
    }
    public void LackTart()
    {
        lackTart = "There isn't enough Tart flavour. ";
    }
    public void OverTart()
    {
        overTart = "There's too much Tart flavour. ";
    }
    public void LackSour()
    {
        lackSour = "There isn't enough Sour flavour. ";
    }
    public void OverSour()
    {
        overSour = "There's too much Sour flavour. ";
    }
    public void LackBitter()
    {
        lackBitter = "There isn't enough Bitter flavour. ";
    }
    public void OverBitter()
    {
        overBitter = "There's too much Bitter flavour. ";
    }
    public void LackWoody()
    {
        lackWoody = "There isn't enough Woody flavour. ";
    }
    public void OverWoody()
    {
        overWoody = "There's too much Woody flavour. ";
    }
    public void LackPeppery()
    {
        lackPeppery = "There isn't enough Peppery flavour. ";
    }
    public void OverPeppery()
    {
        overPeppery = "There's too much Peppery flavour. ";
    }
    public void LackFloral()
    {
        lackFloral = "There isn't enough Floral flavour. ";
    }
    public void OverFloral()
    {
        overFloral = "There's too much Floral flavour. ";
    }
    public void LackEarthy()
    {
        lackEarthy = "There isn't enough Earthy flavour. ";
    }
    public void OverEarthy()
    {
        overEarthy = "There's too much Earthy flavour. ";
    }
    public void LackGreen()
    {
        lackGreen = "There isn't enough Green flavour. ";
    }
    public void OverGreen()
    {
        overGreen = "There's too much Green flavour. ";
    }

    public void ResetDescription()
    {
         lackVolume = null;
         lackAge = null;
         lackSweetness = null;
         overSweetness = null;
         lackAlcohol = null;
         overAlcohol = null;

         lackCitrus = null;
         overCitrus = null;
         lackTart = null;
         overTart = null;
         lackSour = null;
         overSour = null;
         lackBitter = null;
         overBitter = null;
         lackWoody = null;
         overWoody = null;
         lackPeppery = null;
         overPeppery = null;
         lackFloral = null;
         overFloral = null;
         lackEarthy = null;
         overEarthy = null;
         lackGreen = null;
         overGreen = null;
    }

    private void Update()
    {
        failureDescription = lackVolume + lackAge + lackSweetness + overSweetness + lackAlcohol + overAlcohol + lackCitrus + overCitrus + lackTart + overTart + lackSour + overSour + lackBitter + overBitter + lackWoody + overWoody + lackPeppery + overPeppery + lackFloral + overFloral + lackGreen + overGreen + lackEarthy + overEarthy;
    }

}
