using TMPro;
using UnityEngine;

public class PlayerCardUI : MonoBehaviour
{
    // to display the role title and stats
    public TextMeshProUGUI roleText;
    public TextMeshProUGUI statsText;

    public void SetupCard(Player playerStats)
    {
        // role text display
        roleText.text = playerStats.basePlayerCard.roleTitle;
        
        // stats text display
        statsText.text = 
            "Competency: " + playerStats.competency + "\n" +
            "Charisma: " + playerStats.charisma + "\n" +
            "Skill Level: " + playerStats.skillLevel + "\n" +
            "Reputation: " + playerStats.reputation;
    }
}
