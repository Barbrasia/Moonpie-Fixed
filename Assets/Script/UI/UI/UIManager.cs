using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Sprite[] Numbers;
    [SerializeField] private Image cupCake;
    [SerializeField] private Image pie;

    private void Start()
    {
        cupCake.sprite = Numbers[0];
        pie.sprite = Numbers[0];
    }


}
