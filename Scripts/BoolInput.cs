using UnityEngine;

[CreateAssetMenu(fileName = "BoolInput", menuName = "Player/Inputs/BoolInput")]
public class BoolInput : InputBase
{
	public string InputName = "Jump";
	public float FloatValue = 10;
	
	public override float SetFloat()
	{
		return Input.GetButton(InputName) ? FloatValue : 0;
	}
}