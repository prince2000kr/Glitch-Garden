﻿using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile, gun;

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}