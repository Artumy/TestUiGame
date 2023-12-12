using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tickets : MonoBehaviour
{
    public static int countOfTicket;
    
    private TextMeshProUGUI _text;
    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        countOfTicket = 100;
    }
    
    void Start()
    {
        _text.text = countOfTicket.ToString();
    }
}
