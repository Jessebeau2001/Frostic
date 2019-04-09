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
    void Start() {
        endText.text = ("You scored " + points + " points!");
    }
    void Update() {
        pointsText.text = ("" + points);

        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
            points = 0; //resets the points for if you want to start a new game (GitHub bugfix #4)
        }
    }
    public void DebugAdd() {
        points = points + 100;
    }
}
