using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCollider : MonoBehaviour{
    public GameObject player;
    public AudioSource collideSound;
    
    void OnTriggerEnter(Collider col){
        collideSound.Play();
        DesSystem.description = "Find the key";
        StartCoroutine(WaitTime());
    }

    public IEnumerator WaitTime(){
        yield return new WaitForSeconds(3f);
        DesSystem.description = "";
    }
}
