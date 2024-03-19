using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UIElements;
using System.Collections;
using Assembly_CSharp;
using UnityEngine.TestTools;
using Assets.Scripts;
using Unity.Burst.Intrinsics;
using Assets.Scripts.States;

public class MainButtons : MonoBehaviour
{
    SceneManagement _manager = new();

    public void PlayGameButton()
    {
        _manager.LoadSceneByName("Game");
    }

    public void MapButton()
    {
        _manager.LoadSceneByName("Map");
    }

    public void MapBack()
    {
        _manager.LoadSceneByName("Game");
    }

    public void KingdomButton()
    {
        _manager.LoadSceneByName("Kingdom");
    }

    public void KingdomBack()
    {
        _manager.LoadSceneByName("Game");
    }

    public void ClickCutWood()
    {
        if (Money._money >= 100 && Multiply._peoples >= 100)
        {
            Money.MoneyCutWood(100);
            Multiply.MultiplyCutWood(100);
            Wood.CutWood(1);
        }
    }

    public void ClickBuildFarm()
    {
        if (Money._money >= 50 && Multiply._peoples >= 50 && Wood._wood >= 50)
        {
            Money.MoneyBuildFarm(50);
            Multiply.MultiplyBuildFarm(50);
            Wood.WoodBuildFarm(50);
            Farm.BuildFarm(1);
            Food.NewFood(5);
        }
    }

    public void ClickHireMan()
    {
        if (Food._food >= 50)
        {
            Food.HireMan(50);
            Manpower.HireManpower(50);
        }
    }

    public void ResetGame()
    {
        Money.ResetMoney(0);
        Multiply.ResetMultiply(0);
        UpdateTime.ResetAge(15);
        Wood.ResetWood(0, 1);
        Farm.ResetFarm(0);
        Food.ResetFarm(0);
        Manpower.ResetMan(0);
        VilitsoMinor.Reset(2000, 1000, 1500, 100);
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась.");
        Application.Quit();
    }

}
