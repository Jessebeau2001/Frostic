using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onScreenControl : MonoBehaviour
{
    public static int controlDirectionHor;
    public static int controlDirectionVer;
    public PlayerController PlayerController;
    public void onScreenInputHor (int direction) {
        controlDirectionHor = direction;
    }
    public void onScreenInputVer (int direction) {
        controlDirectionVer = direction;
    }
}