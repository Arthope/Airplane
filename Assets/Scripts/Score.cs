using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   [SerializeField] private int _coins;
   [SerializeField] public TextMeshProUGUI Text;

    public void AddOne()
    {
        _coins += 1;
        Text.text = _coins.ToString();
    }
    
}
