using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour{
    
    private float changeScale = 0.05f;

    void Update(){ 
        transform.localScale += new Vector3(changeScale, changeScale, 1) * Time.deltaTime;
    }
}
