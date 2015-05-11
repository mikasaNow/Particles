using UnityEngine;
using UnityEditor;


/*
enum StartLifetime
{
    Constant = 0,
    Curve = 1,
    RandomBetweenTwoConstants = 2,
    RandomBetweenTwoCurve = 3
}
 */


[CustomEditor(typeof(HanaFubukiController))]
public class HanaFubukiControllerInspector : Editor
{
    
    //StartLifetime slt;

    public override void OnInspectorGUI()
    {
        HanaFubukiController obj = target as HanaFubukiController;

        // 総Particle数
        EditorGUILayout.FloatField("TolalParticleNum", obj.tolalParticleNum);
        // 吹出口
        EditorGUILayout.FloatField("RotationSpeed", obj.rotationSpeed);
        EditorGUILayout.Space();

        // パーティクル一覧
        SerializedProperty prop = serializedObject.FindProperty("particleList");
        serializedObject.Update();
        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(prop, true);
        if (EditorGUI.EndChangeCheck())
        {
            serializedObject.ApplyModifiedProperties();
        }
        // MainModule
        obj.mainModule = EditorGUILayout.Foldout(obj.mainModule, "Main");
        if (obj.mainModule == true)
        {
            // MaxParticles
            obj.maxParticles = EditorGUILayout.IntField("MaxParticles", obj.maxParticles);
        }

        // EmissionModule
        obj.emissionModule = EditorGUILayout.Foldout(obj.emissionModule, "Emission");
        if (obj.emissionModule == true)
        {
            obj.emissionRate = EditorGUILayout.Slider("Rate", obj.emissionRate, 0.0f, 200.0f);
        }

        // パーティクルに反映
        foreach (ParticleSystem p in obj.particleList)
        {
            p.emissionRate = obj.emissionRate;
            p.maxParticles = obj.maxParticles;
        }


        /*
        // MainModule
        obj.mainModule = EditorGUILayout.Foldout(obj.mainModule, "Main");
        if (obj.mainModule == true)
        {
            // StartLifeTime
            float startLife;
            slt = (StartLifetime)EditorGUILayout.EnumPopup("StartLifeTime", slt);
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel(" ");
            switch (slt)
            {
                case StartLifetime.Constant:
                    startLife = EditorGUILayout.FloatField(obj.startLifeTimeMin);
                    break;
                case StartLifetime.Curve:
                    break;
                case StartLifetime.RandomBetweenTwoConstants:
                    obj.startLifeTimeMin = EditorGUILayout.FloatField(obj.startLifeTimeMin);
                    obj.startLifeTimeMax = EditorGUILayout.FloatField(obj.startLifeTimeMax);
                    break;
                case StartLifetime.RandomBetweenTwoCurve:
                    break;
            }
            EditorGUILayout.EndHorizontal();

            // StartSpeed
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("StartSpeed");
            obj.startSizeMin = EditorGUILayout.FloatField(obj.startSizeMin);
            obj.startSizeMax = EditorGUILayout.FloatField(obj.startSizeMax);
            EditorGUILayout.EndHorizontal();

            // StartSize
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("StartSize");
            obj.startSizeMin = EditorGUILayout.FloatField(obj.startSizeMin);
            obj.startSizeMax = EditorGUILayout.FloatField(obj.startSizeMax);
            EditorGUILayout.EndHorizontal();

            // StartRotation
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("StartRotation");
            obj.startRotationMin = EditorGUILayout.FloatField(obj.startRotationMin);
            obj.startRotationMax = EditorGUILayout.FloatField(obj.startRotationMax);
            EditorGUILayout.EndHorizontal();

            // StartColor
            obj.startColor = EditorGUILayout.ColorField("StartColor", obj.startColor);

            // GravityModifier
            obj.gravityModifier = EditorGUILayout.FloatField("GravityModifier", obj.gravityModifier);

            // InheritVelocity
            obj.inheritVelocity = EditorGUILayout.FloatField("InheritVelocity", obj.inheritVelocity);

            // SimulationSpace
            obj.simulationSpace = (SimulationSpace)EditorGUILayout.EnumPopup("SimulationSpace", obj.simulationSpace);

            // PlayOnAwake
            obj.playOnAwake = EditorGUILayout.Toggle("PlayOnAwake", obj.playOnAwake);

            // MaxParticles
            obj.maxParticles = EditorGUILayout.FloatField("MaxParticles", obj.maxParticles);

            EditorGUILayout.Space();
        }
        */


        //EditorUtility.SetDirty(target);


    }
}
