using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockGate : MonoBehaviour{
    public AudioSource rockBreakAudio;
    public GameObject originalObject;
    public GameObject fracturedObject;

    public void GateBreak(){
        if(ScoreSystem.score == 5){
            rockBreakAudio.Play();
            DesSystem.description = "Road is now clear.";
            StartCoroutine(WaitTime());
        }else{
            DesSystem.description = "Road is blocked. Find more Mushrooms.";
            StartCoroutine(WaitTime());
        }
    }

    public IEnumerator WaitTime(){
        yield return new WaitForSeconds(3f);  

        if(ScoreSystem.score == 5){
            Destroy(originalObject);
            GameObject fracObject = Instantiate (fracturedObject) as GameObject;
            fracObject.GetComponent<ExplodeRock>().Explode();
            DesSystem.description = "";
        }else{
            DesSystem.description = "";
        }
    }
}
