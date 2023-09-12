using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [field: SerializeField]
    public Rigidbody rb
    {
        get;
        private set;
    }
    [field: SerializeField]
    public float speed
    {
        get;
        set;
    }
    [field: SerializeField]
    public float jumpSpeed
    {
        get;
        set;
    }
    [field: SerializeField]
    public float rotSpeed
    {
        get;
        set;
    }
}
