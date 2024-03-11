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

public class MainButtons : MonoBehaviour
{
    public void PlayGameButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MapButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void MapBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void KingdomButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void KingdomBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
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
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась.");
        Application.Quit();
    }

}
