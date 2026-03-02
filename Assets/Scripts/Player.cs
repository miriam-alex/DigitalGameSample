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
    
    // variables to track score (based on number of plastic/wood chairs made by each player)
    // applied to equation to calculate final score
    public int plasticChairCount;
    public int woodenChairCount;
    public int onCameraTradeCount;
    public int shadyBehaviorCount;
    
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
