using System;

[Serializable]
public class PlayerData
{
    public string playerName;
    public int chosenAppearance;


    public PlayerData(string name, int appearance)
    {
        playerName = name;
        chosenAppearance = appearance;
    }
}
