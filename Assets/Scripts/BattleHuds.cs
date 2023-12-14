using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class BattleHuds : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text levelText;
    public Slider hpSlider;

    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        levelText.text = "Lvl " + unit.unitLevel;
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;

    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
    }
}
