using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl1 : MonoBehaviour

{
    public Animator animator;
    int step;
    public Transform vrCamera;

    void Start()
    {
        step = 1;
        Anim1();

    }
    void Update()
    {
        if (step >= 10)
        {
            Anim2();
        }
    }

    void Anim1()
    {

        animator.SetTrigger("Anim1Run");
      
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Anim1Run"))
        {


            if (vrCamera.eulerAngles.x >= 0 && vrCamera.eulerAngles.x <= 45)
            {

                step += 1;
                Anim1();
            }
        }

    }
    void Anim2()
    {

        animator.SetTrigger("Anim2Run");
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Anim2Run"))
        {
            if (vrCamera.eulerAngles.x >= 0 && vrCamera.eulerAngles.x <= 45)
            {
                step += 1;
                Anim2();
            }
        }


    }
}