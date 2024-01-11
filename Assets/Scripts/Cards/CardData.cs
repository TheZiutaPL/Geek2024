using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Data", menuName = "ScriptableObjects/Card Data")]
public class CardData : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Sprite cardSprite;
}
