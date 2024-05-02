using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class copyText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreFimJogoText;

    void Start()
    {
        scoreFimJogoText.text = scoreText.text;
    }

    void Update()
    {
        
    }
}
