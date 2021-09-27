using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncontrol : MonoBehaviour
{
    // Start is called before the first frame update


    void Update()
    {
        Vector3 gunpos=Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
            
            gunpos.Normalize();

        float angle=Mathf.Atan2(gunpos.y,gunpos.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0f,0f,angle);
      if(angle < -90 || angle > 90)
      {
          transform.localRotation=Quaternion.Euler(180,0,-angle);
      }
    }
}
