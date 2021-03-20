using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Event : MonoBehaviour
{

    public event EventHandler<onCompleteEventNameEventArgs> onCompleteEventName;
    //For Custom Perameters
    public class onCompleteEventNameEventArgs : EventArgs
    {
        public int a;
        public int b;
    }

    public event TestEventDelegate onDelegateEvent;
    //Use Custom DelegateType
    public delegate void TestEventDelegate(float a);

    // Update is called once per frame
    void Update()
    {
        // When Event Occurs Call Event
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Calling with custom perameters
            onCompleteEventName?.Invoke(this, new onCompleteEventNameEventArgs { a = 3, b = 5 }) ;
            //Calling with custom delegate
            onDelegateEvent?.Invoke(2.2f);
        }
    }

    
}


