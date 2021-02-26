﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR.InteractionSystem;

public class ShowController : MonoBehaviour
{

    public bool showcontroller = false;

    // Update is called once per frame
    void Update()
    {
        foreach(var hand in Player.instance.hands)
        {
            if (showcontroller)
            {
                hand.ShowController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController);
            }
            else
            {
                hand.HideController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);
            }
        }
    }
}