using UnityEngine;

[System.Serializable]
public class Card
{
    public enum CardType{
        MUD,
        FARM,
        MAGIC,
        WARRIOR,
    }
    
    public int id;
    public string cardName;
    public string cardDescription;
    public int cost;
    public int attack;
    public int health;
    public CardType type;
    public Sprite image;

    public Card()
    {
        
    }

    public Card(int Id, string CardName, string CardDescription, int Cost, int Attack, int Health, CardType Type, Sprite Image)
    {
        id = Id;
        cardName = CardName;
        cardDescription = CardDescription;
        cost = Cost;
        attack = Attack;
        health = Health;
        type = Type;
        image = Image;
        
    }
}
