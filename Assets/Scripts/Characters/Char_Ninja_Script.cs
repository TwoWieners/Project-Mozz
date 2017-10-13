using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Ninja_Script : BaseCharacter_Script {

	// Use this for initialization
	override public void Start () {
        mAnimator = GetComponent<Animator>();
	}
	// Update is called once per frame
	override public void Update () {
        RunAction();
	}
    override public void JumpAction()
    {

    }
    override public void AttackAction()
    {

    }
    override public void SlidingAction()
    {

    }
    override public void RunAction()
    {
        if (Input.GetKey(KeyCode.A)) // Going Left
        { 

            mAnimator.SetBool("LeftDownPress", true);
            if(transform.localEulerAngles.y != 180)
                transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        else
            if (mAnimator.GetBool("LeftDownPress"))
                mAnimator.SetBool("LeftDownPress", false);

        if (Input.GetKey(KeyCode.D)) // Going Right
        {
            mAnimator.SetBool("RightDownPress", true);
            if(transform.localEulerAngles.y != 0)
                transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else
            if (mAnimator.GetBool("RightDownPress"))
                mAnimator.SetBool("RightDownPress", false);

        if (mAnimator.GetBool("LeftDownPress") && mAnimator.GetBool("RightDownPress"))//Pressing Both Buttons // Goes Idle
        {
            mAnimator.SetBool("LeftDownPress", false);
            mAnimator.SetBool("RightDownPress", false);
        }
    }
    override public void CrouchAction()
    {

    }
    override public void DeathAction()
    {

    }
}
