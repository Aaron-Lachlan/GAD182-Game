using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerPointSystemSO : ScriptableObject
{
	[SerializeField]	
	private float myScore;

	public float Score
	{
		get { return myScore; }
		set { myScore = value; }
	}

}
