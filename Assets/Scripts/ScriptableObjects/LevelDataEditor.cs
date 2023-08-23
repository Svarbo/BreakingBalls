using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LevelsData))]
public class LevelDataEditor : Editor
{
    private LevelsData _levelsData;

    private void Awake()
    {
        _levelsData = (LevelsData)target;
    }

    public override void OnInspectorGUI()
    {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Remove"))
            _levelsData.RemoveCurrentElement();
        if (GUILayout.Button("Add"))
            _levelsData.AddElement();
        if (GUILayout.Button("<="))
            _levelsData.TryGetPreviousLinksIndexes();
        if (GUILayout.Button("=>"))
            _levelsData.TryGetNextLinksIndexes();

        GUILayout.EndHorizontal();
        base.OnInspectorGUI();
    }
}
