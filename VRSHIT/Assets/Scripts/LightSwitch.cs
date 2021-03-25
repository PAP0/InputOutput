using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject lights;
    private bool on = true;
    public SerialController serialController;
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        Debug.Log("Sending A");
        serialController.SendSerialMessage("A");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && on == true)
        {
            lights.SetActive(false);
            on = false;
            Debug.Log("Sending Z");
            serialController.SendSerialMessage("Z");
        }
        else if (collision.gameObject.tag == "Hand" && on == false)
        {
            lights.SetActive(true);
            on = true;
            Debug.Log("Sending A");
            serialController.SendSerialMessage("A");
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
