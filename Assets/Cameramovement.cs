using UnityEngine;

public class Cameramovement : MonoBehaviour {
    public Transform point1, point2, point3, point4;
    public Girl1 someOtherObject;
    public girl2 someOtherObject2;
    public girl3 someOtherObject3;

    // Use this for initialization
    void Start () {


        transform.position = point4.position;
        transform.rotation = point4.rotation;
        someOtherObject2.GetComponent<girl2>().enabled = false;
        someOtherObject3.GetComponent<girl3>().enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
      
            transform.position = point1.position;
            transform.rotation = point1.rotation;
            someOtherObject.Invoke("Girl1", 2f);
            someOtherObject.Invoke("girl2", 2f);

        }
        if (Input.GetKeyDown(KeyCode.B))
        {
         
            transform.position = point2.position;
            transform.rotation = point2.rotation;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
           
            transform.position = point3.position;
            transform.rotation = point3.rotation;
        }
    }
}
