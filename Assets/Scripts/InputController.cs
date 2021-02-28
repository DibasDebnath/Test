using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{


    Controller inputAction;

    //Private Variables
    public bool tap;
    private bool processedTap;
    bool move;
    float moveDisplacement;
    public Vector2 screenTouchPosition;
    Vector2 currentTouchPosition;
    Vector2 oldTouchPosition;


    private void Awake()
    {

        inputAction = new Controller();
        inputAction.Player.TouchStart.performed += ctx => tap = true;
        inputAction.Player.TouchEnd.performed += ctx => tap = false;
        inputAction.Player.TouchMove.performed += ctx => screenTouchPosition = ctx.ReadValue<Vector2>();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }







    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }
}
