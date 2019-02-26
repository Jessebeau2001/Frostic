using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSys : MonoBehaviour
{
    public static int points;
    public Text pointsText;
    public Text endText;
    void Update () {
        pointsText.text = ("" + points);
        endText.text = ("You scored " + points + " points!");
    }
}
