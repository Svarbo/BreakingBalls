using UnityEngine;
using IJunior.TypedScenes;

public class LevelLoader : MonoBehaviour, ISceneLoadHandler<int>
{
    private int _levelNumber;

    public int LevelNumber => _levelNumber;

    public void OnSceneLoaded(int levelNumber)
    {
        _levelNumber = levelNumber;
    }
}
