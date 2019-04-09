using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    private onScreenControl onScreenControl;
    private PointSys pt; //reference to the PoinSys script
    public GameObject MobileControls;
    public GameObject DebugButtons;
    private Rigidbody2D rb;
    void Start() {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Movement();
        // MobileMovement();

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
            Debug.Log("Quit");
        }

        if (Input.GetKeyDown(KeyCode.F1)){
            if (MobileControls.activeSelf) {
                MobileControls.SetActive(false);
            } else {
                MobileControls.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.F2)){
            if (DebugButtons.activeSelf) {
                DebugButtons.SetActive(false);
            } else {
                DebugButtons.SetActive(true);
            }
        }
    }
    void Movement() {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        rb.velocity = new Vector2(moveHorizontal, moveVertical);
    }
    void MobileMovement() {
        float moveVertical = onScreenControl.controlDirectionVer * moveSpeed * Time.deltaTime;
        float moveHorizontal = onScreenControl.controlDirectionHor * moveSpeed * Time.deltaTime;

        rb.velocity = new Vector2(moveHorizontal, moveVertical);
    }
    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){
            case "Coin":
                Destroy(col.gameObject);
                PointSys.points += 50;
                break;
            case "Gem":
                Destroy(col.gameObject);
                PointSys.points += 100;
                break;
            case "Money_Bag":
                Destroy(col.gameObject);
                PointSys.points += 75;
                break;
            case "Treasure_Chest":
                Destroy(col.gameObject);
                PointSys.points += 125;
                break;
            case "Gold_Cluster":
                Destroy(col.gameObject);
                PointSys.points += 75;
                break;
        }
    }
}