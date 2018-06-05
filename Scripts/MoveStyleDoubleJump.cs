using UnityEngine;

[CreateAssetMenu(fileName = "MoveStyleDoubleJump", menuName = "Player/MoveStyle/MoveStyleDoubleJump")]
public class MoveStyleDoubleJump : MoveStyleBase 
{
	public MoveStyleBase MoveStyle;
	public bool DoubleJumped = false;
	
	public override void Move(MovePatternBase MovePattern)
	{
		if (!DoubleJumped)
		{
			MoveStyle.Move(MovePattern);
			DoubleJumped = true;
		}
		
		if (MovePattern.Controller.isGrounded)
		{
			DoubleJumped = false;
		}
	
	}
}
