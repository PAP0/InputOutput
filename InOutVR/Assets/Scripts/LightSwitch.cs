using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject spotlight2;
    public GameObject bwokenBottle;
    public GameObject script2;
    public SerialController serialController;
    
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Sending B");
        serialController.SendSerialMessage("B");
    }

    void Try()
    {
        serialController.SendSerialMessage("G");
    }

    void Update()
    {
        if (bwokenBottle.activeSelf == true)
        {
            Try();
            script2.SetActive(false);
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
