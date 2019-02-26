using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private PointSys pt; //reference to the PoinSys script
    void Start()
    {
        pt = GameObject.FindGameObjectWithTag("PointSystem").GetComponent<PointSys>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(new Vector3(moveHorizontal, moveVertical));
    }

    void OnTriggerEnter2D(Collider2D col) {
        switch (col.gameObject.tag){
            case "Coin":
                Destroy(col.gameObject);
                pt.points += 50;
                break;
            case "Gem":
                Destroy(col.gameObject);
                pt.points += 100;
                break;
            case "Money_Bag":
                Destroy(col.gameObject);
                pt.points += 75;
                break;
            case "Treasure_Chest":
                Destroy(col.gameObject);
                pt.points += 125;
                break;
            case "Gold_Cluster":
                Destroy(col.gameObject);
                pt.points += 75;
                break;
        }
    }
}