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

        transform.Translate(new Vector3(moveHorizontal, moveVertical + floatY.y));

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown("1"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        }
        else if (Input.GetKeyDown("2"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 66, 66, 255);
        }
        else if (Input.GetKeyDown("3"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(0, 255, 0, 255);
        }

        floatY.y = (Mathf.Sin(hoverSpeed * Time.time) * FloatStrength);
    }
}