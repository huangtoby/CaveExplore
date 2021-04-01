using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCollect : MonoBehaviour{
    public AudioSource collectAudio;

    public void PointerClick(){
        collectAudio.Play();
        ScoreSystem.score += 1;
        Destroy(gameObject);
    }
}
