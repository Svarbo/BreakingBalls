using UnityEngine;
using IJunior.TypedScenes;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private LevelLoader _levelLoader;

    public void LoadMainMenu()
    {
        MainMenu.Load(0);
    }

    public void LoadLevel(int levelNumber)
    {
        Game.Load(levelNumber);
    }

    public void RestartCurrentLevel()
    {
        Game.Load(_levelLoader.LevelNumber);
    }

    public void LoadNextLevel()
    {
        int nextLevelIndex = _levelLoader.LevelNumber + 1;
        Game.Load(nextLevelIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
