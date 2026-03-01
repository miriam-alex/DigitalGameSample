using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerCard basePlayerCard;
    public PlayerCardUI playerCardUI;
    
    // the stats that each character has a different amount of depending on role
    public int competency;
    public int charisma;
    public int skillLevel;
    public int reputation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // copies the stats provided by the base player card (database that was created)
        competency = basePlayerCard.competency;
        charisma = basePlayerCard.charisma;
        skillLevel = basePlayerCard.skillLevel;
        reputation = basePlayerCard.reputation;
        
        playerCardUI.SetupCard(this);
    }
}
