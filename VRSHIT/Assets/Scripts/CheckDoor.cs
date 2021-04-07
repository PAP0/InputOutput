using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDoor : MonoBehaviour
{

    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;

    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        Door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    void Check()
    {
        if (Cube1.activeSelf == false)
        {
            if (Cube2.activeSelf == false)
            {
                if (Cube3.activeSelf == false)
                {
                    if (Cube4.activeSelf == false)
                    {
                        Door.SetActive(false);
                    }
                }
            }
        }
    }
}
