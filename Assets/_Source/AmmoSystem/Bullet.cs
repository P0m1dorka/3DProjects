using System;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float lifeTime;
        [SerializeField] private float speed;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = gameObject.GetComponent<Rigidbody>();
        }

        private void MoveForward()
        {
            //
        }

        private void OnCollisionEnter(Collision other)
        {
            Destroy(gameObject);
        }
    }
}
