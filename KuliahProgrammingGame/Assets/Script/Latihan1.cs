using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour
{
    // values type : int, float, double, bool, char, structs
    // reference : string, classes
    
    // modifier access : public, protected, private, default

    // Start is called before the first frame update
    void Start(){
        Debug.Log("Start Dipanggil!");
    }

    /*void Awake() {
        Debug.Log("Awake Dipanggil!");
    }
    */

    // Update is called once per frame
    void Update(){
        Debug.Log("Waktu untuk Update :" + Time.deltaTime);
    }
    
    void FixedUpdate() {
        Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
    }

    void LateUpdate() {
        Debug.Log("Waktu untuk LateUpdate :" + Time.deltaTime);
    }
}
