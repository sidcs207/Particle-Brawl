using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
      public GameObject bulletPrefab;
      public AudioSource shoot;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
          shoot.Play();
            Shoot();
        }
    }

    void Shoot ()
    {
       Instantiate(bulletPrefab,firepoint.position,firepoint.rotation);
    }
}
