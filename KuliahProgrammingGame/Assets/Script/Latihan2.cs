using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{
    public int nilaiA = 5;
    public int nilaiB = 9;
        [Range (1,5)]
        public int nilaiC = 1;

    // Start is called before the first frame update
    void Start()
    {
        int total = (nilaiA + nilaiB) * nilaiC;
        Debug.Log("Total nilai = " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
