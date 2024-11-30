using NUnit.Framework;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;


[System.Serializable]
public class DisplayCard : MonoBehaviour
{
    public Card displayCard = new Card();
    public int displayID;
    
    public int id;
    public string cardName;
    public string cardDescription;
    public int cost;
    public int attack;
    public int health;
    public Card.CardType type;
    public Sprite image;
    
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;
    public Image cardImage;
    public Image artImage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CardDatabase.Awake();
        displayCard = CardDatabase.cards[displayID];
        id = displayCard.id;
        cardName = displayCard.cardName;
        cardDescription = displayCard.cardDescription;
        cost = displayCard.cost;
        attack = displayCard.attack;
        health = displayCard.health;
        type = displayCard.type;
        image = displayCard.image;
        
        nameText.text = "" + cardName;
        descriptionText.text = "" + cardDescription;
        attackText.text = "" + attack;
        healthText.text = "" + health;
        artImage.sprite = image;

        
        if (type == Card.CardType.MUD)
        {
            cardImage.tag = "Mud";
            cardImage.color = new Color(61f/255f,40f/255f,23f/255f);
        }
        else if (type == Card.CardType.FARM)
        {
            cardImage.tag = "Farm";
            cardImage.color = new Color(53f/255f,109f/255f,41f/255f);  
        }
        else if (type == Card.CardType.MAGIC)
        {
            cardImage.tag = "Magic";
            cardImage.color = new Color(0f/255f,115f/255f,207f/255f);  
        }
        else if (type == Card.CardType.WARRIOR)
        {
            cardImage.tag = "Warrior";
            cardImage.color = new Color(107f/255f,27f/255f,27f/255f);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
