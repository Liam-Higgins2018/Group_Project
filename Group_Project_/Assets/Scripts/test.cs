using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public static bool firstRight = true;
    public static bool firstLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        /*var swipeSpace = 0;
        while(swipeSpace < 500)
        {
            swipeSpace++;
            transform.Translate(1f * Time.deltaTime ,0 ,0);
        }*/
        
           
        
    }

    // Update is called once per frame
    void Update()
    {

        //> 11.5
        //< -9
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 11)
        {
            var swipeSpace = 0;
            
            if(firstRight == true && firstLeft == true)
            {
                firstRight = false;
                firstLeft = false;
                while(swipeSpace < 250)
                {
                    swipeSpace++;
                    var pos = transform.position;
                    pos.x += 0.005f;
                    transform.position = pos;
                }
                
            }
            else
            {
                while(swipeSpace < 500)
                {
                    swipeSpace++;
                    var pos = transform.position;
                    pos.x += 0.01f;
                    transform.position = pos;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -8.5)
        {
            var swipeSpace = 0;
            if(firstRight == true && firstLeft == true)
            {
                firstRight = false;
                firstLeft = false;
                var pos = transform.position;
                pos.x -= 2.5f;
                transform.position = pos;
            }
            else
            {
                var pos = transform.position;
                pos.x -= 5f;
                transform.position = pos;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var pos = transform.position;
            pos.z += 0.5f;
            transform.position = pos;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var swipeSpace = 0;
            //while(swipeSpace < 1)
            //{
                //swipeSpace++;
                //transform.Translate(transform.position.x ,0 ,0);
                //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
                var pos = transform.position;
                pos.y += 5f;
                transform.position = pos;
                //pos.y -= 5f;
                //transform.position = pos;
            //}
        }
    }
}
