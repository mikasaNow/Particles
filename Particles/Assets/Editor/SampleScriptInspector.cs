using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SampleScript))]
public class SampleScriptInspector : Editor
{

    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();
        SampleScript obj = target as SampleScript;
        obj.freq = EditorGUILayout.Slider("Frequency", obj.freq, 0.0f, 10.0f);
        EditorUtility.SetDirty(target);
    }
}
