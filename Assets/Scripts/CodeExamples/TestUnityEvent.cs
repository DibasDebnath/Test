using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestUnityEvent : MonoBehaviour
{
    public UnityEvent unityEventName;

    public UnityEvent<int> unityEventNameWithPerameter;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            unityEventName.Invoke();
            unityEventNameWithPerameter.Invoke(2);
        }
    }

    
}
