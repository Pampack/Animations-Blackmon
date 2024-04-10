using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyAnimation : MonoBehaviour
{
    private bool noKeyPressed;
    private Animator dummyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        dummyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardKey = Input.GetKey(KeyCode.W);
        bool backKey = Input.GetKey(KeyCode.S);
        bool jumpKey = Input.GetKeyDown(KeyCode.Space);
        bool duckKey = Input.GetKeyDown(KeyCode.LeftControl);
        bool backstepKey = Input.GetKeyDown(KeyCode.LeftShift);
        bool leftKey = Input.GetKey(KeyCode.A);
        bool rightKey = Input.GetKey(KeyCode.D);

        if(forwardKey == true || backKey == true || jumpKey == true || duckKey == true || backstepKey == true || leftKey == true || rightKey == true) 
        { 
            noKeyPressed = false;
        }
        else
        {
            noKeyPressed = true;
        }

        dummyAnimator.SetBool("forwardKeyPress", forwardKey);
        dummyAnimator.SetBool("backKeyPress", backKey);
        dummyAnimator.SetBool("jumpKeyPress", jumpKey);
        dummyAnimator.SetBool("duckKeyPress", duckKey);
        dummyAnimator.SetBool("backstepKeyPress", backstepKey);
        dummyAnimator.SetBool("noKeyPressed", noKeyPressed);
        dummyAnimator.SetBool("leftStrafePressed", leftKey);
        dummyAnimator.SetBool("rightStrafePressed", rightKey);
    }
}
