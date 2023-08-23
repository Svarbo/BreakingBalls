using UnityEngine;

public class GameReseter : MonoBehaviour
{
    public void ResetLevels()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("OpenLevelsNumber", 1);
    }
}