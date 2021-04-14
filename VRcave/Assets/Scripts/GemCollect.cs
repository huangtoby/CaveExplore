using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour{
    public AudioSource collectAudio;
    public AudioClip GemSound;

    public void PointerClick(){
        collectAudio.GetComponent<AudioSource>().clip = GemSound;
        collectAudio.Play();
        ScoreSystem.score += 1;
        Destroy(gameObject);
    }
}
