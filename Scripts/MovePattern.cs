using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovePattern", menuName = "Player/MovePatterns/MovePattern")]
public class MovePattern : MovePatternBase
{
	public MoveStyleBase MoveStyle;
	
	public override void Move(CharacterController controller, Transform transform)
	{
		Controller = controller;
		ObjTransform = transform;
		
		MoveStyle.Move(this);
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}	
}