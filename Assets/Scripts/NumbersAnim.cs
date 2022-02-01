using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersAnim : MonoBehaviour
{
    public int speed = 3;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0));
    }
}