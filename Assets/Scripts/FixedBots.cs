using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FixedBots : MonoBehaviour
{
    public int FixedBotsAmount;
    public TextMeshProUGUI FixedBotsText;

    public int TotalBots = 4;

    // Start is called before the first frame update
    void Start()
    {
        FixedBotsAmount = 0;
        FixedBotsText.text = "Fixed Robots: " + FixedBotsAmount;
    }

    public void IncrementFixedBots()
    {
        FixedBotsAmount += 1;
        FixedBotsText.text = "Fixed Robots: " + FixedBotsAmount;
    }
}