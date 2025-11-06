using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData playerData;
    void Start()
    {
        playerData.dirtCount = 0;
        Debug.Log("Baþlangýç Elmas Sayýsý: " + playerData.diamondCount);

    }

    void Update()
    {
        
    }
    public void CollectDiamond()
    {
        playerData.AddDiamond(1); 
        Debug.Log("Yeni Elmas Sayýsý: " + playerData.diamondCount);
    }
    public void CollectDirt()
    {
        playerData.AddDirt(1);
        Debug.Log("Yeni Toprak Sayýsý: " + playerData.dirtCount);
    }
    }
