using UnityEngine;

[CreateAssetMenu(fileName = "PlayerCard", menuName = "Scriptable Objects/PlayerCard")]
public class PlayerCard : ScriptableObject
{
    // title of the role
    public string roleTitle;

    // the stats that each character has a different amount of depending on role
    public int competency;
    public int charisma;
    public int skillLevel;
    public int reputation;

}