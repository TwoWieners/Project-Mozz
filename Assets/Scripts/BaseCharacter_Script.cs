
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseCharacter_Script : MonoBehaviour {

    public struct Weapon
    {
        float mRange, mRateofFire, mProjectileSpeed;
        GameObject 
            mWeapon, //The Weapon and it's animation if needed
            mProjectile; //Projectile for the Weapon and it's animation

    }

    public ushort mHealth, mDamage;
    public uint mMovementSpeed;

    public Weapon mWeapon;
    protected Animator mAnimator; //The Different Animations for the different movements
    public GameObject[] mHitboxes; //Depending on the character, they'll have different hitboxes

    // Use this for initialization
    virtual public void Start () {
		
	}
	
	// Update is called once per frame
	virtual public void Update () {
		
	}

    virtual public void JumpAction()
    {

    }
    virtual public void AttackAction()
    {

    }
    virtual public void SlidingAction()
    {

    }
    virtual public void RunAction()
    {

    }
    virtual public void CrouchAction()
    {

    }
    virtual public void DeathAction()
    {

    }
}
