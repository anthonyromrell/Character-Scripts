using ArtisanDream.CharacterScripts.Scripts;
using UnityEngine;

public abstract class MoveStyleBase : ScriptableObject, IMove
{
	public abstract void Move(MovePatternBase MovePattern);
}