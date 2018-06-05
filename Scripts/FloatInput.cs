using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

[CreateAssetMenu(fileName = "FloatInput", menuName = "Player/Inputs/FloatInput")]
public class FloatInput : InputBase, IInput
{

	public string InputName = "Horizontal";
	
	public override float SetFloat ()
	{
		return Input.GetAxis(InputName);
	}
}