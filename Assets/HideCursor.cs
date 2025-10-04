using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    public bool showCursor = false;
    // Start is called before the first frame update
    void Start()
    {
        if (showCursor)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
