using UnityEngine;

[CreateAssetMenu(fileName = "MoveStlyeIsGroundedElse")]
public class MoveStlyeIsGroundedElse : MoveStyle 
{
	public MoveStyleBase MoveStyle;
	
	public override void Move(MovePatternBase MovePattern)
	{
		if (MovePattern.Controller.isGrounded)
		{
			MoveStyle.Move(MovePattern);
		}
		else
		{
			MoveStyle.Move(MovePattern);
		}
	}
	
}