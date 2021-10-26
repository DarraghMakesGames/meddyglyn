using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequirementCheck : MonoBehaviour
{

    public float targetVolume;
    public float actualVolume;
    public bool matchesReq = false;
    private Transform toBeChecked;

    void Update()
    {
        if (this.gameObject.transform.childCount > 0){
            toBeChecked = this.gameObject.transform.GetChild(0);
            actualVolume = toBeChecked.GetComponent<StorageManager>().capacity;
        }
        else if (this.gameObject.transform.childCount < 1){
            toBeChecked = null;
            actualVolume = 0;
        }


        if (actualVolume == targetVolume)
        {
            matchesReq = true;
        }
        else
        {
            matchesReq = false;
        }

    }
}
