using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadControl : MonoBehaviour
{
    public int correctCombination;
    public bool accessGranted;

    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        Door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(accessGranted == true)
        {
            accessGranted = false;
            Door.SetActive(false);
        }
    }

    public bool CheckIfCorrect(int combination)
    {
        if(combination == correctCombination)
        {
            accessGranted = true;
            return true;
        }
        return false;
    }
}
