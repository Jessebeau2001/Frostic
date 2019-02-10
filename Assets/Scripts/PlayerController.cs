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
    private SpriteRenderer spriteRender;

    public Sprite icySpirit;
    public Sprite hatsu;

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

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown("1"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = icySpirit;
            print("switched to IcySpirit");
        }
        else if (Input.GetKeyDown("2"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hatsu;
            print("switched to Hatsu");
        }
        else if (Input.GetKeyDown("3"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(0, 255, 0, 255);
        }
    }
}