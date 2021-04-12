using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour{
    public GameObject originalObject;
    public GameObject handObject;

    public void PointerClick(){
        Destroy(originalObject);
        handObject.SetActive(true);
    }
}
