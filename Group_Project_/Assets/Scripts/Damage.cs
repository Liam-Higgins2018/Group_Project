using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //Gets trigger on colision
    private void OnTriggerEnter()
    {
        GameObject.Find("Robot_Kyle").GetComponent<Health>().health -= 1;
    }
}
