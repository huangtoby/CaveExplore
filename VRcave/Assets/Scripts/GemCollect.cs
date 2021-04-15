using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour{
    public AudioSource collectAudio;
    public AudioClip gemSound;
    public GameObject spawnShroom1, spawnShroom2, spawnShroom3, spawnShroom4,spawnShroom5;

    public void PointerClick(){
        collectAudio.GetComponent<AudioSource>().clip = gemSound;
        collectAudio.Play();
        ScoreSystem.score += 1;
        Destroy(gameObject);

        if(ScoreSystem.score == 5){
            spawnShroom1.SetActive(true);
            spawnShroom2.SetActive(true);
            spawnShroom3.SetActive(true);
            spawnShroom4.SetActive(true);
            spawnShroom5.SetActive(true);
        }
    }
}
