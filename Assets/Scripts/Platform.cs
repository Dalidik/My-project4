using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject Ball;

    private void Awake()
    {
        Ball.SetActive(false);
    }
    private void OnTriggerEnter()
    {

        Ball.SetActive(true);

    }

    private void OnTriggerExit()
    {
        Ball.SetActive(false);
    }
}
