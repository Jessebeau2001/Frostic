using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointSys : MonoBehaviour
{
    public static int points;
    public Text pointsText;
    public Text endText;
    void Update () {
        pointsText.text = ("" + points);
        endText.text = ("You scored " + points + " points!");

        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }
}
