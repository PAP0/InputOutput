using System;
using TMPro;
using UnityEngine;

public class KeyDetector : MonoBehaviour
{
    private TextMeshPro Display;

    private KeyPadControl keyPadControll;
    // Start is called before the first frame update
    void Start()
    {
        Display = GameObject.FindGameObjectWithTag("Display").GetComponentInChildren<TextMeshPro>();
        Display.text = "";

        keyPadControll = GameObject.FindGameObjectWithTag("Keypad").GetComponent<KeyPadControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KeypadButton"))
        {
            var key = other.GetComponentInChildren<TextMeshPro>();
            if (key != null)
            {
                var keyFeedBack = other.gameObject.GetComponent<KeyFeedBack>();
                if (key.text == "Back")
                {
                    if (Display.text.Length > 0)
                    {
                        Display.text = Display.text.Substring(0, Display.text.Length - 1);
                    }
                }
                else if (key.text == "Enter")
                {
                    var accessGranted = false;
                    bool onlyNumber = int.TryParse(Display.text, out int value);
                    if (onlyNumber == true && Display.text.Length > 0)
                    {
                        accessGranted = keyPadControll.CheckIfCorrect(Convert.ToInt32(Display.text));
                    }

                    if (accessGranted == true)
                    {
                        Display.text = "Start";
                    }
                    else
                    {
                        Display.text = "Retry";
                    }
                }
                else if (key.text == "Cancel")
                {
                    Display.text = "";
                }
                else
                {
                    bool onlyNumber = int.TryParse(Display.text, out int value);
                    if (onlyNumber == false)
                     {
                        Display.text = "";
                     }

                    if(Display.text.Length < 4)
                    {
                        Display.text += key.text;
                    }
                    keyFeedBack.keyHit = true;
                }
            }
        }
    }
}
