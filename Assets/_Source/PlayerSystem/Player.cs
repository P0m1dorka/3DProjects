using System;
using UnityEngine;

namespace PlayerSystem
{
   [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float movementSpeed { get; private set; }
        [field: SerializeField] public Rigidbody Rb { get; set; }
        [SerializeField] private float rotationSpeed;
        [SerializeField] private float jumpForce;
        [field: SerializeField] public Transform firePoint { get; private set; }
        [field: SerializeField] public GameObject bulletPrefab { get; private set; }
        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
        }
    }
}
