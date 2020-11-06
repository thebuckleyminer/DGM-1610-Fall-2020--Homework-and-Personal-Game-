using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerStayEvent, triggerExitEvent, awakeEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerStayEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerExitEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }
}
