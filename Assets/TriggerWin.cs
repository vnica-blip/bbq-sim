using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {

        }
    }
}
