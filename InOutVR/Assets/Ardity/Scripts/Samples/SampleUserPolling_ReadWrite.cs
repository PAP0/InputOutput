/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections.Generic;
using System.Collections;

/**
 * Sample for reading using polling by yourself, and writing too.
 */
public class SampleUserPolling_ReadWrite : MonoBehaviour
{
    public SerialController serialController;

    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Press A or Z to execute some actions");

        Debug.Log("Sending A");
        serialController.SendSerialMessage("A");

        Debug.Log("Sending B");
        serialController.SendSerialMessage("B");

        Debug.Log("Sending C");
        serialController.SendSerialMessage("C");
    }

    // Executed each frame
    void Update()
    {
        //---------------------------------------------------------------------
        // Send data
        //---------------------------------------------------------------------

        // If you press one of these keys send it to the serial device. A
        // sample serial device that accepts this input is given in the README.
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
        
    }
}
