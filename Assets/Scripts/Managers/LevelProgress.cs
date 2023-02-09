using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{
    
    private int currentLevel = 1;
    public int CurrentLevel => currentLevel;

    protected override void Awake()
    {
        base.Awake();

        Load();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) == true)
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.F2) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            currentLevel++;
            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("LevelProgress:CurrentLevel", currentLevel);
    }

    private void Load()
    {
        currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
    }

    private void Reset()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
