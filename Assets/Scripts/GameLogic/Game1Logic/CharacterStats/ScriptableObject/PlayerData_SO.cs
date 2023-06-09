using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data", menuName = "Character Stats/Data")]
public class PlayerData_SO : ScriptableObject
{

    [Header("Stats Info")]
    public int maxHealth;
    public int currentHealth;
    public int score;

    [Header("other info")] 
    public string waitToDiscuss;


}