using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
public GameObject spotlight1;
public GameObject spotlight2;
public GameObject spotlight3;
public GameObject bwokenWire;
public GameObject winWindow;
private int E;
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
        Debug.Log("Sending F");
        serialController.SendSerialMessage("F");
        spotlight1.SetActive(true);
    }

    if (E >= 3)
    {
        E = 3;
    }

    if (spotlight1.activeSelf)
    {
        winWindow.SetActive(true);
    }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Sending A");
            serialController.SendSerialMessage("A");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Sending B");
            serialController.SendSerialMessage("B");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Sending C");
            serialController.SendSerialMessage("C");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Sending F");
            serialController.SendSerialMessage("F");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Sending G");
            serialController.SendSerialMessage("G");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Sending H");
            serialController.SendSerialMessage("H");
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

