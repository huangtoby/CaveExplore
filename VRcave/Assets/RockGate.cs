using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGate : MonoBehaviour{
    public AudioSource rockBreakAudio;
    
    public void GateBreak(){
        if(ScoreSystem.score == 5){
            rockBreakAudio.Play();
            StartCoroutine(WaitTime());
        }
    }

    IEnumerator WaitTime(){
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
