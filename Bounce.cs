using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Vector3 movement;
    bool goingDown;
    // Start is called before the first frame update
    void Start()
    {
        goingDown = true;

        movement = new Vector3(0, (float)0.02, 0);
    }

    // Update is called once per frame
    void Update()
    {

        

        if (GameObject.Find("Sphere").transform.position.y - GameObject.Find("ImageTarget").transform.position.y >= 3)
        {
            goingDown = true;
        }else if (GameObject.Find("Sphere").transform.position.y - GameObject.Find("ImageTarget").transform.position.y <= 0)
        {
            goingDown = false;
        }
       
        if (goingDown)
        {
            GameObject.Find("Sphere").transform.position -= movement;
        }
        else
        {
            GameObject.Find("Sphere").transform.position += movement;
        }
        Debug.Log(GameObject.Find("Sphere").transform.position);
    }
}
