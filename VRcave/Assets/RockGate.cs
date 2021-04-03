using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockGate : MonoBehaviour{
    public AudioSource rockBreakAudio;

    public void GateBreak(){
        if(ScoreSystem.score == 5){
            rockBreakAudio.Play();
            StartCoroutine(WaitTime());
        }else{
            DesSystem.description = "Find more Mushrooms";
            StartCoroutine(WaitTime());
        }
    }

    public IEnumerator WaitTime(){
        yield return new WaitForSeconds(3f);
        if(ScoreSystem.score <5){
            DesSystem.description = "";
        }else{
            Destroy(gameObject);
        }
    }
}
