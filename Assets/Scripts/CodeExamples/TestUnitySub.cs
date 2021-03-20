using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestUnitySub : MonoBehaviour
{
    public TestUnityEvent testUnityEvent;

    

    private void Awake()
    {
        testUnityEvent = this.GetComponent<TestUnityEvent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Add Method to Event Using Funtion
        testUnityEvent.unityEventName.AddListener(MehodeToCall);
        // Add Methods using perameters 
        testUnityEvent.unityEventNameWithPerameter.AddListener(MehodeToCall);

    }

    public void MehodeToCall()
    {
        Debug.Log("Unity Event Call From Subscriber");
        testUnityEvent.unityEventName.RemoveListener(MehodeToCall);
    }
    public void MehodeToCall(int a)
    {
        Debug.Log("Unity Event Call From Subscriber " + a);
        //Remove Method to Event Using Funtion
        // Remove Methods using Methode
        testUnityEvent.unityEventNameWithPerameter.RemoveListener(MehodeToCall);
    }
}
