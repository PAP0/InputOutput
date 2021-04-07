using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Light1 : MonoBehaviour
{
    public SerialController serialController;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void turnOff()
    {
        Debug.Log("Sending F");
        serialController.SendSerialMessage("F");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
