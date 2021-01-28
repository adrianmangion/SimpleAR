using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    /// <summary>
    /// Start spawning cube.
    /// </summary>
    /// <param name="spawner"></param>
    public void StartSpawner(GameObject spawner)
    {
        spawner.SetActive(true);
    }

    /// <summary>
    /// Stop spawning cube.
    /// </summary>
    /// <param name="spawner"></param>
    public void StopSpawner(GameObject spawner)
    {
        spawner.SetActive(false);
    }
}
