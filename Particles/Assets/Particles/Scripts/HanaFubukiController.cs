using UnityEngine;
using System.Collections.Generic;
using UnityEditor;


public enum SimulationSpace
{
    World = 0,
    Local = 1
}

public class HanaFubukiController : MonoBehaviour
{

	public List<ParticleSystem> particleList = new List<ParticleSystem>();
	public float rotationSpeed;
	public float tolalParticleNum;

	// MainModule
	public bool mainModule;

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

    public float maxParticles;




	// EmissionModule
	public bool emissionModule;
	public float emissionRate;
	
	private float beforeEmissionRate;

	void Start () {
	}
	

	void Update () {

        // emissionRate更新
        if (emissionRate != beforeEmissionRate)
        {
            foreach (ParticleSystem p in particleList)
            {
                p.transform.Rotate(new Vector3(0, rotationSpeed, 0), Space.World);
                p.emissionRate = emissionRate;
                beforeEmissionRate = emissionRate;
                //Debug.Log(p.name + ":" + p.particleCount);
            }
        }

        // 総パーティクル
        tolalParticleNum = 0;
        foreach (ParticleSystem p in particleList)
        {
            tolalParticleNum += p.particleCount;
        }


        // work start
        /*
        switch (simulationSpace)
        {
            case SimulationSpace.World:
                Debug.Log("World");
                break;

            case SimulationSpace.Local:
                Debug.Log("Local");
                break;

            default:
                break;
        }
        */
        // work end

	}
}
