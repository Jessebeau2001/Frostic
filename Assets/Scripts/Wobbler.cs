using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobbler : MonoBehaviour
{
    public float FloatStrength;
    public float hoverSpeed;
    private Vector3 floatY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        floatY.y = (Mathf.Sin(hoverSpeed * Time.time) * FloatStrength);
        transform.Translate(new Vector3(0, floatY.y));
    }
}
