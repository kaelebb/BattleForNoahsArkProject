using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public int damageAmount = 20;
    public GameObject StarterStick;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;
    public bool IsAttacking = false;
    public AudioClip StickAttackSound;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(CanAttack)
            {
                StickAttack();
            }
        }
    }

    // private void onTriggerEnter(Collider other)
    // {
    //     if(other.tag == "Enemy");
    //     {
    //         other.GetComponent<BearStats>().TakeDamage(damageAmount);
    //     }
    // }

    public void StickAttack()
    {
        IsAttacking = true;
        CanAttack = false;
        Animator animator = StarterStick.GetComponent<Animator>();
        animator.SetTrigger("Attack");
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(StickAttackSound);
        StartCoroutine(ResetAttackCooldown()); 
        
    }

    IEnumerator ResetAttackCooldown()
    {
        StartCoroutine(ResetAttackBool());
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    }

    IEnumerator ResetAttackBool()
    {
        yield return new WaitForSeconds(1.0f);
        IsAttacking = false;
    }

}
