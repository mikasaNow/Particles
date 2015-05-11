using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SampleScript))]
public class SampleScriptInspector : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}
