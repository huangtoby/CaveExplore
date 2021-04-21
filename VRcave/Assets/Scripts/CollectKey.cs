using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour{
    public GameObject originalObject;
    public GameObject handObject;
    public GameObject forceField;

    public void PointerClick(){
        Destroy(originalObject);
        handObject.SetActive(true);
        forceField.SetActive(false);
        DesSystem.description = "The barrier is down";
        StartCoroutine(WaitTime());
    }

    public IEnumerator WaitTime(){
        yield return new WaitForSeconds(3f);
        DesSystem.description = "";
    }
}
