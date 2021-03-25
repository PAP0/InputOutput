using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject lightSwitch;
    private bool on = true;
    public SerialController serialController;
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            lightSwitch.SetActive(!lightSwitch.activeSelf);
        }
    }

}
