using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstructions : MonoBehaviour{
    public void StartDescription(){
        DesSystem.description = "Discover and Collect";
        StartCoroutine(WaitTimeA());
    }

    public IEnumerator WaitTimeA(){
        yield return new WaitForSeconds(5f);
        DesSystem.description = "Mushrooms are key";
        StartCoroutine(WaitTimeB());
    }

    public IEnumerator WaitTimeB(){
        yield return new WaitForSeconds(5f);
        DesSystem.description = "";
    }

    void Start(){
        StartDescription();
    }
}
