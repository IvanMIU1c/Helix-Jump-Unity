using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private int scores;

    private int comboCheck=1;
    public int Scores => scores;

    [SerializeField] private int recordScores;
    public int RecordScores => recordScores;

    protected override void Awake()
    {
        base.Awake();
        Load();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel*comboCheck;
            comboCheck++;
        }

        if(type == SegmentType.Default)
        {
            comboCheck = 1;
        }

        if (type == SegmentType.Finish)
        {
            if (scores > recordScores) 
            {
                recordScores = scores;

                Save();
            }
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("ScoreCollector:RecordScores", recordScores);
    }

    private void Load()
    {
        recordScores = PlayerPrefs.GetInt("ScoreCollector:RecordScores", 0);
    }
}
