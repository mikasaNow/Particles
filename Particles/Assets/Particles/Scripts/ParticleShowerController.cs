using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class ParticleShowerController : MonoBehaviour {

	public List<ParticleSystem> particleList = new List<ParticleSystem>();

	[Range(0f, 1000f)]
	public float EmissionRate;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		foreach (ParticleSystem p in particleList) {
			p.emissionRate = EmissionRate;
		}
	}
}
