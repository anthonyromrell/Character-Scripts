using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
	public static Coroutines Instance;

	private void Start()
	{
		Instance = this;
	}
}
