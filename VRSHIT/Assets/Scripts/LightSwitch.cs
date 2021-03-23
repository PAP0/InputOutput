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
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Press A or Z to execute some actions");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            lightSwitch.SetActive(!lightSwitch.activeSelf);
        }
    }

}
