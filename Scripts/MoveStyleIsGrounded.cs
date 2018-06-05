using UnityEngine;

[CreateAssetMenu(fileName = "MoveStyleIsGrounded", menuName = "Player/MoveStyle/IsGrounded")]
public class MoveStyleIsGrounded : MoveStyleBase
{
	public MoveStyleBase MoveStyle;
	
	public override void Move(MovePatternBase MovePattern)
	{
		if (MovePattern.Controller.isGrounded)
		{
			MoveStyle.Move(MovePattern);
		}
	}
}
