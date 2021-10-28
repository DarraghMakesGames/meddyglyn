using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueCalculator : MonoBehaviour
{
    //This class takes variables from the parent vessel object to calculate the value of the product per ml - used when moving to storage

    public float rawValue;
    public float valuePerMl;
    [SerializeField] private float sweet;
    [SerializeField] private float alcohol;
    [SerializeField] private float citrus;
    [SerializeField] private float tart;
    [SerializeField] private float sour;
    [SerializeField] private float bitter;
    [SerializeField] private float woody;
    [SerializeField] private float peppery;
    [SerializeField] private float floral;
    [SerializeField] private float earthy;
    [SerializeField] private float green;
    [SerializeField] private float batchAmount;

    [SerializeField] private float sweetValue;
    [SerializeField] private float alcoholValue;
    [SerializeField] private float citrusValue;
    [SerializeField] private float tartValue;
    [SerializeField] private float sourValue;
    [SerializeField] private float bitterValue;
    [SerializeField] private float woodyValue;
    [SerializeField] private float pepperyValue;
    [SerializeField] private float floralValue;
    [SerializeField] private float earthyValue;
    [SerializeField] private float greenValue;

    private bool finished;

    private void Update()
    {
        //This only runs until the fermentation process is finished - values are then static
        //This is to preserve the value per ml while parts of the brew are removed & bottled
        finished = GetComponent<VesselManager>().isFinished;

        if (!finished)
        {
            sweet = GetComponent<VesselManager>().sweetnessStrength-0.5f;
            alcohol = GetComponent<VesselManager>().alcohol+1;
            citrus = GetComponent<VesselManager>().citrusStrength;
            tart = GetComponent<VesselManager>().tartStrength;
            sour = GetComponent<VesselManager>().sourStrength;
            bitter = GetComponent<VesselManager>().bitterStrength;
            woody = GetComponent<VesselManager>().bitterStrength;
            peppery = GetComponent<VesselManager>().pepperyStrength;
            floral = GetComponent<VesselManager>().floralStrength;
            earthy = GetComponent<VesselManager>().earthyStrength;
            green = GetComponent<VesselManager>().greenStrength;
            batchAmount = GetComponent<VesselManager>().totalLiquidContent;

            sweetValue = sweet * 2;
            alcoholValue = alcohol * 2;
            citrusValue = citrus;
            tartValue = tart;
            sourValue = sour;
            bitterValue = bitter;
            woodyValue = woody;
            pepperyValue = peppery;
            floralValue = floral;
            earthyValue = earthy;
            greenValue = green;
        }

        rawValue = sweetValue + alcoholValue + citrusValue + tartValue + sourValue + bitterValue + woodyValue + pepperyValue + floralValue + earthyValue + greenValue;
        valuePerMl = rawValue / batchAmount;




}


}
