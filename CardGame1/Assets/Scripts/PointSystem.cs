using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI pointsTxt;
    void Update()
    {
        pointsTxt.text = "Points: " + points.ToString();
    }
}
