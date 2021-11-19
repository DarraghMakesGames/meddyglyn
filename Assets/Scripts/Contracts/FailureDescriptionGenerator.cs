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
        lackVolume = "You didn't make enough!";
    }
    public void LackAge()
    {
        lackAge = "You didn't age it for long enough.";
    }
    public void LackSweetness()
    {
        lackSweetness = "It isn't sweet enough.";
    }
    public void OverSweetness()
    {
        overSweetness = "It's too sweet.";
    }
    public void LackAlcohol()
    {
        lackAlcohol = "It isn't sweet enough.";
    }
    public void OverAlcohol()
    {
        overAlcohol = "It's too sweet.";
    }
    public void LackCitrus()
    {
        lackCitrus = "It isn't sweet enough.";
    }
    public void OverCitrus()
    {
        overCitrus = "It's too sweet.";
    }
    public void LackTart()
    {
        lackTart = "It isn't sweet enough.";
    }
    public void OverTart()
    {
        overTart = "It's too sweet.";
    }
    public void LackSour()
    {
        lackSour = "It isn't sweet enough.";
    }
    public void OverSour()
    {
        overSour = "It's too sweet.";
    }
    public void LackBitter()
    {
        lackBitter = "It isn't sweet enough.";
    }
    public void OverBitter()
    {
        overBitter = "It's too sweet.";
    }
    public void LackWoody()
    {
        lackWoody = "It isn't sweet enough.";
    }
    public void OverWoody()
    {
        overWoody = "It's too sweet.";
    }
    public void LackPeppery()
    {
        lackPeppery = "It isn't sweet enough.";
    }
    public void OverPeppery()
    {
        overPeppery = "It's too sweet.";
    }
    public void LackFloral()
    {
        lackFloral = "It isn't sweet enough.";
    }
    public void OverFloral()
    {
        overFloral = "It's too sweet.";
    }
    public void LackEarthy()
    {
        lackEarthy = "It isn't sweet enough.";
    }
    public void OverEarthy()
    {
        overEarthy = "It's too sweet.";
    }
    public void LackGreen()
    {
        lackGreen = "It isn't sweet enough.";
    }
    public void OverGreen()
    {
        overGreen = "It's too sweet.";
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
