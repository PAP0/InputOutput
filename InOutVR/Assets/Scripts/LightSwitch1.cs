using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch1 : MonoBehaviour
{
    public GameObject spotlight3;
    public GameObject bwokenWire;
    public GameObject script3;
    public SerialController serialController;
    
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Sending C");
        serialController.SendSerialMessage("C");

    }


    void Try2()
    {
        //spotlight3.SetActive(true);
        serialController.SendSerialMessage("H");
    }

    void Update()
    {
        if (bwokenWire.activeSelf == true)
        {
            Try2();
            script3.SetActive(false);
        }

        //---------------------------------------------------------------------
        // Receive data
        //---------------------------------------------------------------------

        string message = serialController.ReadSerialMessage();

        if (message == null)
            return;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");
        else
            Debug.Log("Message arrived: " + message);
    }

}
