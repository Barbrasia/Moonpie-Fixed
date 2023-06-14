using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Sprite[] Numbers;
    [SerializeField] private Image cupCake;
    [SerializeField] private Image pie;

    public Cupcakes cupcakes;

    private void Start()
    {
        cupCake.sprite = Numbers[0];
        pie.sprite = Numbers[0];
    }

    public void UpdateCupcakeIndex(int newIndex)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (i == newIndex)
            {
                cupCake.sprite = Numbers[i];
                cupCake.gameObject.SetActive(true);
            }
        }
    }

    public void UpdatePieIndex(int newIndex)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (i == newIndex)
            {
                pie.sprite = Numbers[i];
                pie.gameObject.SetActive(true);
            }
        }
    }
}
