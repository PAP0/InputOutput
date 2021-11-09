using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlightson : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject wire;
    public GameObject door;
    public GameObject potion;
    public GameObject exit;


    // Update is called once per frame
    void Update()
    {
        if(potion.activeSelf == true)
        {
            light2.SetActive(true);
        }
        if (door.activeSelf == false)
        {
            light1.SetActive(true);
        }
        if (wire.activeSelf == true)
        {
            light3.SetActive(true);
        }
        if(light1.activeSelf == true)
        {
            if (light2.activeSelf == true)
            {
                if (light3.activeSelf == true)
                {
                    exit.SetActive(false);
                }
            }
        }
    }
}
