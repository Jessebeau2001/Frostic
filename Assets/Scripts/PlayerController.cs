using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float FloatStrength;
    public float hoverSpeed;

    private Animator anim;
    private Vector3 floatY;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        floatY.y = (Mathf.Sin(hoverSpeed * Time.time) * FloatStrength);

        transform.Translate(new Vector3(moveHorizontal, moveVertical + floatY.y));
    }
}