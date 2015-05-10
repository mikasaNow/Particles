using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class HanaFubukiController : MonoBehaviour
{

	public List<ParticleSystem> particleList = new List<ParticleSystem>();

    public int startLifeTimeMin;
    public int startLifeTimeMax;
    public float starSpeed;
    public float startSize;
    public float startRotation;

    public float emissionRate;
    public float rotationSpeed;
    public int tolalParticleNum;
    public int a;
    public int b;

    private float beforeEmissionRate;
	void Start () {
	}
	

	void Update () {
        tolalParticleNum = 0;
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

        foreach (ParticleSystem p in particleList)
        {
            tolalParticleNum += p.particleCount;
        }

	}
}
