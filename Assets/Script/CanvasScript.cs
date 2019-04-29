using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {
    public Text canvasText1, canvasText2, canvasText3, canvasText4, canvasText5, canvasText6;
    public GameObject panel;
   
    // Use this for initialization
    void Start () {
        panel.SetActive(true);
        canvasText1.gameObject.SetActive(false);
        canvasText2.gameObject.SetActive(false);
        canvasText3.gameObject.SetActive(false);
        canvasText4.gameObject.SetActive(false);
        canvasText5.gameObject.SetActive(false);
        canvasText6.gameObject.SetActive(false);

        Invoke("DisableText1", 0.2f);//invoke after 5 seconds
    }
    void DisableText1()
    {
        canvasText1.gameObject.SetActive(true);
        Invoke("DisableText2", 2f);
    }

   void DisableText2()
    {
       
        canvasText1.gameObject.SetActive(false);
        canvasText2.gameObject.SetActive(true);

        Invoke("DisableText3", 2f);
    }

    void DisableText3()
    {
        canvasText2.gameObject.SetActive(false);
        canvasText3.gameObject.SetActive(true);
        Invoke("DisableText4", 2f);
    }
    
    void DisableText4()
    {
        canvasText3.gameObject.SetActive(false);
        canvasText4.gameObject.SetActive(true);
        Invoke("DisableText5", 2f);
    }
    void DisableText5()
    {
        canvasText4.gameObject.SetActive(false);
        canvasText5.gameObject.SetActive(true);
        Invoke("DisableText6", 2f);
    }
    void DisableText6()
    {
        canvasText5.gameObject.SetActive(false);
        canvasText6.gameObject.SetActive(true);
    }


}
