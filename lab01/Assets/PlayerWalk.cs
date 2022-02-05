using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    public int playerSpeed;
    public float start = -30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
       // if(Camera.main.transform.rotation.eulerAngles.x >= -10 && Camera.main.transform.eulerAngles.x < 40)
        //{

            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;

//        }
      
    }
}
