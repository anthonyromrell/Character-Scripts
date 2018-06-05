using UnityEngine;

[CreateAssetMenu(fileName = "StandarMoveStyle", menuName = "Player/MoveStyle/StandarMoveStyle")]
public class MoveStyle : MoveStyleBase 
{
	public override void Move(MovePatternBase MovePattern)
	{	
		MovePattern.rotateDirection.Set(
			MovePattern.InputRotateX.SetFloat(), 
			MovePattern.InputRotateY.SetFloat(), 
			MovePattern.InputRotateZ.SetFloat());
			
		MovePattern.ObjTransform.Rotate(MovePattern.rotateDirection);
			
		MovePattern.moveDirection.Set(
			MovePattern.InputX.SetFloat(),
			MovePattern.InputY.SetFloat(),
			MovePattern.InputZ.SetFloat());
			
		MovePattern.moveDirection = MovePattern.ObjTransform.TransformDirection(MovePattern.moveDirection);
			
		MovePattern.moveDirection *= MovePattern.speed;	
		MovePattern.moveDirection.y = MovePattern.JumpInput.SetFloat();
	}
}