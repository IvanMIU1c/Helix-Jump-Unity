using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImputManager : BallEvents
{
    [SerializeField] private MouseRotator inputRotator;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish || type == SegmentType.Trap)
        {
            inputRotator.enabled = false;
        }
    }
}
