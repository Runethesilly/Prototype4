using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private bool isPushed = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isPushed)
        {
            Debug.Log("Button was pushed");

        }
    }

}
