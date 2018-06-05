using UnityEngine;


public abstract class MovePatternBase : ScriptableObject
{
	public float speed = 6.0F;
	public float gravity = 20.0F;

	public Vector3 moveDirection;
	public Vector3 rotateDirection;

	public InputBase InputX, InputY, InputZ;
	
	public InputBase InputRotateX, InputRotateY, InputRotateZ;
	
	public InputBase JumpInput;
	[HideInInspector] public CharacterController Controller;
	[HideInInspector] public Transform ObjTransform;

	public abstract void Move(CharacterController controller, Transform transform);
}