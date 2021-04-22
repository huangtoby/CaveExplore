using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActive : MonoBehaviour{
    public AudioSource forceAudio;

    void Awake(){
        forceAudio.Play();
        Debug.Log(forceAudio);
        DesSystem.description = "The barrier is down";
        StartCoroutine(WaitTime());
    }

    public IEnumerator WaitTime(){
        yield return new WaitForSeconds(3f);
        DesSystem.description = "";
        Debug.Log("Coroutine Hit");
    }
}
