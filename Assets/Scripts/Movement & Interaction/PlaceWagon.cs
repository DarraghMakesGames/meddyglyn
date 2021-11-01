using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceWagon : MonoBehaviour
{

    private GameObject CarriedObject;
    private Transform carriedPos;
    private GameObject carriedObj;
    private Transform carried;

    private Transform pickup;

    [SerializeField] Transform pos1;
    [SerializeField] Transform pos2;
    [SerializeField] Transform pos3;
    [SerializeField] Transform pos4;
    [SerializeField] Transform pos5;
    [SerializeField] Transform pos6;
    [SerializeField] Transform pos7;
    [SerializeField] Transform pos8;

    private void Start()
    {
        CarriedObject = GameObject.Find("CarriedObject");
        carriedPos = GameObject.Find("CarriedObject").transform;
    }


    public void Interacted()
    {
        if (CarriedObject.transform.childCount < 1)
        {
            if (pos8.gameObject.transform.childCount > 0)
            {
                pickup = pos8.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos7.gameObject.transform.childCount > 0)
            {
                pickup = pos7.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos6.gameObject.transform.childCount > 0)
            {
                pickup = pos6.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos5.gameObject.transform.childCount > 0)
            {
                pickup = pos5.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos4.gameObject.transform.childCount > 0)
            {
                pickup = pos4.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos3.gameObject.transform.childCount > 0)
            {
                pickup = pos3.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos2.gameObject.transform.childCount > 0)
            {
                pickup = pos2.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }
            else if (pos1.gameObject.transform.childCount > 0)
            {
                pickup = pos1.gameObject.transform.GetChild(0);
                pickup.position = carriedPos.position;
                pickup.rotation = Quaternion.identity;
                pickup.transform.parent = carriedPos;
                CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
            }

        }
        else
        {
            carried = CarriedObject.gameObject.transform.GetChild(0);
            carriedObj = carried.transform.gameObject;

            if (carriedObj.gameObject.CompareTag("Ingredient"))
            {
                Debug.Log("Only accepts finished brews");
            }

            else if (carriedObj.gameObject.CompareTag("Storage"))
            {
                Debug.Log("Adding brew");
                if (pos1.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos1.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos1;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos2.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos2.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos2;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos3.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos3.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos3;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos4.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos4.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos4;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos5.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos5.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos5;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos6.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos6.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos6;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos7.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos7.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos7;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else if (pos8.gameObject.transform.childCount <= 0)
                {
                    carried.position = pos8.position;
                    carried.rotation = Quaternion.identity;
                    carried.transform.parent = pos8;
                    CarriedObject.GetComponent<CarryingManager>().playPlaceSound();
                }
                else
                {
                    Debug.Log("No room on wagon");
                }


            }
        }

    }
}
