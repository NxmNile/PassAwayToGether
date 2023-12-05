using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseItem : MonoBehaviour
{
    [SerializeField] private GameObject ItemScreen;
    [SerializeField] private PlayerController2 _playerController2;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject slipper;
    [SerializeField] private GameObject slipperButton;
    [SerializeField] private GameObject swatter;
    public void EnergyDrink()
    {
        //health.AddHP(1);
        //swatter.SetActive(true);
        _playerController2.AddHP();
        ItemScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void Slipper()
    {
        slipperButton.SetActive(false);
        ItemScreen.SetActive(false);
        swatter.SetActive(false);
        slipper.SetActive(true);
        Time.timeScale = 1;
    }
    
}
