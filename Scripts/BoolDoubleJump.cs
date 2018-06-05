using UnityEngine;

[CreateAssetMenu(fileName = "BoolDoubleJump", menuName = "Player/Inputs/BoolDoubleJump")]
public class BoolDoubleJump : BoolInput 
{
	
	public override float SetFloat()
	{
		return Input.GetButton(InputName) ? FloatValue : 0;
	}
}