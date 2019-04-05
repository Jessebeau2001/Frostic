using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator anim;
    private onScreenControl onScreenControl;
        void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        anim.SetFloat("MoveX", onScreenControl.controlDirectionHor);
        anim.SetFloat("MoveY", onScreenControl.controlDirectionVer);
    }
}