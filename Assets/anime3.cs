using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class anime3 : MonoBehaviour

{
    public Animator animator;

    void Start()
    {
        StartCoroutine(Anim1(1500));
        StartCoroutine(Anim2(3300));



    }

    IEnumerator Anim1(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            animator.SetTrigger("Anim5Run");
            yield return 0;
        }
    }
    IEnumerator Anim2(int number2)
    {
        for (int i = 0; i <= number2; i++)
        {
            animator.SetTrigger("Anim6Run");
            yield return 0;
        }


    }
}