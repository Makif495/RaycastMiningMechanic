using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    public int diamondCount; 
    public int dirtCount;

    public void AddDiamond(int amount)
    {
        diamondCount += amount; 
    }
    public void AddDirt(int amount)
    {
        dirtCount += amount;
    }
}

