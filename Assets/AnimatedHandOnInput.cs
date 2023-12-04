using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatedHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float triggerPress = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerPress);

        float gripPress = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripPress);
    }
}
