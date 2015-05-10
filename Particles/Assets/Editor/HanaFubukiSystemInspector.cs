using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(HanaFubukiController))]

public class HanaFubukiControllerInspector : Editor
{

    public override void OnInspectorGUI()
    {
        HanaFubukiController obj = target as HanaFubukiController;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("startLifeTime");
        obj.a = EditorGUILayout.IntSlider(obj.startLifeTimeMin, 0, 50);
        obj.b = EditorGUILayout.IntSlider(obj.startLifeTimeMax, 0, 50);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.FloatField("rotationSpeed", obj.rotationSpeed);

        EditorGUILayout.IntField("tolalParticleNum", obj.tolalParticleNum);

        obj.emissionRate = EditorGUILayout.Slider("emissionRate", obj.emissionRate, 0.0f, 300.0f);



        //EditorUtility.SetDirty(target);
    }
}
