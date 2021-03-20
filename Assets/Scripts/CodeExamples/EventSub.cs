using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSub : MonoBehaviour
{

    public Event eventObj;

    private void Awake()
    {
        eventObj = GetComponent<Event>();
    }

    // Start is called before the first frame update
    void Start()
    {
        eventObj.onCompleteEventName += MethodCall;
        eventObj.onDelegateEvent += delegateCall;
        
    }

   
    void MethodCall(object obj, Event.onCompleteEventNameEventArgs e)
    {
        Debug.Log($"Calling From Subscriber {e.a} {e.b} Done");
        eventObj.onCompleteEventName -= MethodCall;
    }
    void delegateCall(float e)
    {
        Debug.Log($"Calling From Subscriber {e} Done");
        eventObj.onDelegateEvent -= delegateCall;
    }


}
