﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorPreyAcademy : Academy 
{

	/// <summary>
	/// The "walking speed" of the agents in the scene. 
	/// </summary>
	public float agentRunSpeed;

	/// <summary>
	/// The agent rotation speed.
	/// Every agent will use this setting.
	/// </summary>
	public float agentRotationSpeed;

	/// <summary>
	/// The spawn area margin multiplier.
	/// ex: .9 means 90% of spawn area will be used. 
	/// .1 margin will be left (so players don't spawn off of the edge). 
	/// The higher this value, the longer training time required.
	/// </summary>
	public float spawnAreaMarginMultiplier;

	/// <summary>
	/// When a a prey is killed the ground will switch to this 
	/// material for a few seconds.
	/// </summary>
	public Material goalScoredMaterial;

	/// <summary>
	/// When an agent fails, the ground will turn this material for a few seconds.
	/// </summary>
	public Material failMaterial;

	/// <summary>
	/// The gravity multiplier.
	/// Use ~3 to make things less floaty
	/// </summary>
	public float gravityMultiplier;

	void State()
	{
		Physics.gravity *= gravityMultiplier;

	}


}
