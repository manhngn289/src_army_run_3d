using System;
using UnityEngine;

[Serializable]
public class ShieldData
{
	public float maxShield;

	public float currentShield;

	public ParticleSystem dmgShieldFX;

	public ParticleSystem breakShieldFX;

	public GameObject shieldGO;
}
