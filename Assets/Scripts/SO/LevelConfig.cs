using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Create level config")]

public class LevelConfig : ScriptableObject
{
    public float Volume { get; private set; }

    public void GetVolume(float volume)
    {
        Volume = volume;
    }
}
