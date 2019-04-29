using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class girl2 : MonoBehaviour

{
    public Animator animator;

    void Start()
    {
        StartCoroutine(Anim1(1200));
        StartCoroutine(Anim2(2700));



    }

    IEnumerator Anim1(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            animator.SetTrigger("Anim3Run");
            yield return 0;
        }
    }
    IEnumerator Anim2(int number2)
    {
        for (int i = 0; i <= number2; i++)
        {
            animator.SetTrigger("Anim4Run");
            yield return 0;
        }


    }
}