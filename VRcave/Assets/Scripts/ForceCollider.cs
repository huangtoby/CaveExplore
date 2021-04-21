using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCollider : MonoBehaviour{
    public GameObject player;
    public AudioSource collideSound;
    
    void OnTriggerEnter(Collider col){
        collideSound.Play();
    }
}
