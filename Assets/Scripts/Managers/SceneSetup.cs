using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private BallController ballController;
    [SerializeField] private LevelProgress gameProgress;

    private void Start()
    {
        levelGenerator.Generate(gameProgress.CurrentLevel);

        ballController.transform.position = new Vector3(ballController.transform.position.x, levelGenerator.LastFloorY, ballController.transform.position.z);
    }
}
