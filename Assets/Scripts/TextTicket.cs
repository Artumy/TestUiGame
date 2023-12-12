using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextTicket : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    
    public void addTickets()
    {
        Tickets.countOfTicket += 5;
        _text.text = Tickets.countOfTicket.ToString();
    }
}
