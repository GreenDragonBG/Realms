using System.Collections;
using UnityEngine;
using System.Collections.Generic;
    public class CardDatabase : MonoBehaviour 
    { 
        public static List<Card> cards = new List<Card>();

        void Awake()
        {
            cards.Add(new Card(0,"Mud Golem","Creature made of mud sustaind by maigc", 4, 4,5,Card.CardType.MUD,Resources.Load<Sprite>("Assets/Cards/ImageSprites/MudGolem")));
            cards.Add(new Card(1,"Mush", "Giant poisiones mushroom", 4,1,7, Card.CardType.FARM,Resources.Load<Sprite>("Assets/Cards/ImageSprites/Mush")));
            cards.Add(new Card(2,"Hound Commander", "A great dog knight", 2, 3, 2,Card.CardType.WARRIOR,Resources.Load<Sprite>("Assets/Cards/ImageSprites/DogCommander") ));
            cards.Add(new Card(3,"Battle Wizard", "A master in the arts of magic", 2, 3,1,Card.CardType.MAGIC,Resources.Load<Sprite>("Assets/Cards/ImageSprites/BattleWizard") ));
        }

    }