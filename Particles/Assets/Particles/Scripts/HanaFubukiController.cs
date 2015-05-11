using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

/*
public enum SimulationSpace
{
    World = 0,
    Local = 1
}
*/

public class HanaFubukiController : MonoBehaviour
{

	public List<ParticleSystem> particleList = new List<ParticleSystem>();
	public float tolalParticleNum = 0;
    public float rotationSpeed = 0;

	// MainModule
	public bool mainModule = true;
    public int maxParticles = 0;

    /*
    public float startLifeTimeMin;
    public float startLifeTimeMax;

	public float startSpeedMin;
    public float startSpeedMax;

    public float startSizeMin;
    public float startSizeMax;
    
    public float startRotationMin;
    public float startRotationMax;

    public Color startColor;

    public float gravityModifier;

    public float inheritVelocity;

    public SimulationSpace simulationSpace;

    public bool playOnAwake;
    */


    // EmissionModule
	public bool emissionModule;
	public float emissionRate;
	

	void Start () {
	}
	

	void Update () {

        // 吹出口回転
        foreach (ParticleSystem p in particleList)
        {
            p.transform.Rotate(new Vector3(0, rotationSpeed, 0), Space.World);
        }

        // 総パーティクル
        tolalParticleNum = 0;
        foreach (ParticleSystem p in particleList)
        {
            tolalParticleNum += p.particleCount;
        }
	}
}
