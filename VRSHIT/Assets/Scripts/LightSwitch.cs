using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject spotlight1;
    public GameObject spotlight2;
    public GameObject bwokenWire;
    public GameObject bwokenBottle;
    public GameObject door;
    public SerialController serialController;
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Sending A");
        serialController.SendSerialMessage("A");

        Debug.Log("Sending B");
        serialController.SendSerialMessage("B");

        Debug.Log("Sending C");
        serialController.SendSerialMessage("C");

    }



    void Update()
    {
        if (bwokenWire.activeSelf)
        {
            spotlight1.SetActive(true);
            Debug.Log("Sending F");
            serialController.SendSerialMessage("F");
        }
        if (bwokenBottle.activeSelf)
        {
            spotlight2.SetActive(true);
            Debug.Log("Sending G");
            serialController.SendSerialMessage("G");
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
