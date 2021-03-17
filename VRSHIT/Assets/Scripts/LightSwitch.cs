using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject lightSwitch;
    private bool on = false;

    //void Hit()
    //{
    // if (on == false)
    // {
    //     light.SetActive(true);
    //     on = true;
    // }
    // else if (on == true)
    //  {
    //       light.SetActive(false);
    //       on = false;
    //   }
    //}
    //void Update()
    //{
    //   if (Input.GetKeyDown("space"))
    //  {
    //      Hit();
    //   }
    //
    //}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            lightSwitch.SetActive(!lightSwitch.activeSelf);
        }
    }

}
