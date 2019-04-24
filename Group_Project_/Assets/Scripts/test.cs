using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed = 0.5f;
    
    //public static bool firstLeft = true;
    // Start is called before the first frame update
    void Start()
    {

        var pos = transform.position;
        pos.x = 1.250103f;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 11)
        {
            var swipeSpace = 0;
            
            /*if(firstRight == true && firstLeft == true)
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
            {*/
                while(swipeSpace < 500)
                {
                    swipeSpace++;
                    var pos = transform.position;
                    pos.x += 0.01f;
                    transform.position = pos;
                }
            //}
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -8.5)
        {
            var swipeSpace = 0;
            /*if(firstRight == true && firstLeft == true)
            {
                firstRight = false;
                firstLeft = false;
                var pos = transform.position;
                pos.x -= 2.5f;
                transform.position = pos;
            }
            else
            {*/
                var pos = transform.position;
                pos.x -= 5f;
                transform.position = pos;
            //}
        }

        if(GameObject.Find("Character").GetComponent<Score>().levelDifficulty == 2)
        {
            speed = 0.6f;
        }
        else if(GameObject.Find("Character").GetComponent<Score>().levelDifficulty == 3)
        {
            speed = 0.7f;
        }
        else if(GameObject.Find("Character").GetComponent<Score>().levelDifficulty == 4)
        {
            speed = 0.8f;
        }
        else if(GameObject.Find("Character").GetComponent<Score>().levelDifficulty == 5)
        {
            speed = 0.9f;
        }
        else if(GameObject.Find("Character").GetComponent<Score>().levelDifficulty == 6)
        {
            speed = 1f;
        }

        var run = transform.position;
        run.z += speed;
        transform.position = run;


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