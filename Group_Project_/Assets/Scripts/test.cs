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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var swipeSpace = 0;
            while(swipeSpace < 500)
            {
                swipeSpace++;
                transform.Translate(1f * Time.deltaTime ,0 ,0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
