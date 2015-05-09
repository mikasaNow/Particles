using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class HanaFubukiController : MonoBehaviour
{

	public List<ParticleSystem> particleList = new List<ParticleSystem>();

    [Header("Commons Setting")]
    [Range(0f, 100f)]
    public float emissionRate;
    public float rotationSpeed;
        
    private float beforeEmissionRate;

	void Start () {
	}
	

	void Update () {
        foreach (ParticleSystem p in particleList)
        {
            p.transform.Rotate(new Vector3(0, rotationSpeed, 0), Space.World);

            if (emissionRate != beforeEmissionRate)
            {
                p.emissionRate = emissionRate;
                beforeEmissionRate = emissionRate;
            }
            //Debug.Log(p.name + ":" + p.particleCount);
        }
	}
}
