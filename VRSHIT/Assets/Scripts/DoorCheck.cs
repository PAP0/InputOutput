using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject spotlight3;
    public GameObject Door;
    public SerialController serialController;

    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        Door.SetActive(true);
    }
    void Update()
    {
        if(Cube1.activeSelf == false)
        {
            if (Cube2.activeSelf == false)
            {
                if (Cube3.activeSelf == false)
                {
                    if (Cube4.activeSelf == false)
                    {
                        Door.SetActive(false);
                        spotlight3.SetActive(true);
                        Debug.Log("Sending H");
                        serialController.SendSerialMessage("H");
                    }
                }
            }
        }
    }
}
