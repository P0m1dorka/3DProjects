using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysic : MonoBehaviour
{
    [field: SerializeField]
    private float lifeTime
    {
        get;
        set;
    }

    [field: SerializeField]
    private float speed
    {
        get;
        set;
    }

    [field: SerializeField]
    private Rigidbody rb
    {
        get;
        set;
    }
    private void Start()
    {
        MoveForward();
        StartCoroutine(Life());
    }
    public void MoveForward()
    {
      rb.AddForce(Vector3.forward*speed,ForceMode.Impulse);
    }

    private IEnumerator Life()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Destroy");
        Destroy(gameObject);
    }
}
