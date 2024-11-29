using NUnit.Framework;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Image = UnityEngine.UIElements.Image;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayID;
    
    public int id;
    public string cardName;
    public string cardDescription;
    public int cost;
    public int attack;
    public int health;
    public Card.CardType type;
    public Sprite image;
    
    public TextMeshPro nameText;
    public TextMeshPro descriptionText;
    public TextMeshPro attackText;
    public TextMeshPro healthText;
    public Image ArtImage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        displayCard[0] = CardDatabase.cards[displayID];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cardDescription = displayCard[0].cardDescription;
        cost = displayCard[0].cost;
        attack = displayCard[0].attack;
        health = displayCard[0].health;
        type = displayCard[0].type;
        image = displayCard[0].image;
        
        nameText.text = "" + cardName;
        descriptionText.text = "" + cardDescription;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
