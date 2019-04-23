using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var swipeSpace = 0;
            //while(swipeSpace < 1)
            //{
                //swipeSpace++;
                //transform.Translate(transform.position.x ,0 ,0);
                //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
                var pos = transform.position;
                pos.x += 0.5f;
                transform.position = pos;
            //}
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var swipeSpace = 0;
            //while(swipeSpace < 1)
            //{
                //swipeSpace++;
                //transform.Translate(transform.position.x ,0 ,0);
                //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
                var pos = transform.position;
                pos.x -= 0.5f;
                transform.position = pos;
            //}
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var swipeSpace = 0;
            //while(swipeSpace < 1)
            //{
                //swipeSpace++;
                //transform.Translate(transform.position.x ,0 ,0);
                //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
                var pos = transform.position;
                pos.z += 0.5f;
                transform.position = pos;
            //}
        }
        if (Input.GetKey(KeyCode.Space))
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
