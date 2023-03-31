using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    public Text healthtext;
    PlayerHealth playerStats;

    void Start()
    {
        playerStats = GetComponent<PlayerHealth>();
        

    }
}
