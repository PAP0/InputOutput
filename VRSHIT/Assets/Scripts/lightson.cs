using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightson : MonoBehaviour
{
    public GameObject spotlight1;
    public GameObject door;
    public SerialController serialController;

    void Start()
{
    serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

}

void Try()
{
    //spotlight1.SetActive(true);
}


void Update()
{
    if (door.activeSelf == true)
    {
        Try();
        
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
