using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my_tetrino_segment : MonoBehaviour
{
    public void MyDropTetrino(bool isPositive)
    {
        if (isPositive)
            transform.Translate(0, -1, 0);
        else
            transform.Translate(0, 1, 0);
        
        
    }
}
