using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoreCollector scoreCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text recordText;
    [SerializeField] private string markRecordText;

    private void Start()
    {
        recordText.text = markRecordText + " : " + scoreCollector.RecordScores;
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Default || type == SegmentType.Finish)
        {
            scoreText.text = scoreCollector.Scores.ToString();
        }

        if (type == SegmentType.Finish)
        {
            recordText.text = markRecordText + " : " + scoreCollector.RecordScores;
        }
    }


}
