using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGamePanel : BallEvents
{
    [SerializeField] private GameObject passedPanel;
    [SerializeField] private GameObject defeatPanel;

    private void Start()
    {
        passedPanel.SetActive(false);
        defeatPanel.SetActive(false);
    }


    protected override void OnBallCollisionSegment(SegmentType type)
    {
        base.OnBallCollisionSegment(type);

        if ((type == SegmentType.Trap) == true)
        {
            defeatPanel.SetActive(true);
        }

        if ((type == SegmentType.Finish) == true)
        {
            passedPanel.SetActive(true);
        }
    }
}
