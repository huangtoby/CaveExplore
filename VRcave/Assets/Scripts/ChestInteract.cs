using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : MonoBehaviour{
    public GameObject chestCap;
    public AnimationClip open;
    public AnimationClip close;
    
    public void ChestOpen(){
        if(chestCap.GetComponent<Animation>().clip == open){
            chestCap.GetComponent<Animation>().Play();
            chestCap.GetComponent<Animation>().clip = close;
        }
    }

    public void ChestClose(){
        if(chestCap.GetComponent<Animation>().clip == close){
            chestCap.GetComponent<Animation>().Play();
            chestCap.GetComponent<Animation>().clip = open;
        }
    }
}
