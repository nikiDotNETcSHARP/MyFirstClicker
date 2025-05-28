using UnityEngine;
using Assembly_CSharp;
using Assets.Scripts;
using Assets.Scripts.States;

public class MainButtons : MonoBehaviour
{
    static SceneManagement _manager = new();

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

    public void MultiplyPeoples()
    {
        if (Food._food >= 10)
        {
            Multiply._peoples += Multiply._multiply;
            Food._food -= Multiply._multiply;

            PlayerPrefs.SetInt("_peoples", Multiply._peoples);
            PlayerPrefs.SetInt("_food", Food._food);
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
        if (Food._food >= 50 && Multiply._peoples >= 50)
        {
            Food.HireMan(50);
            Manpower.HireManpower(50);
            Multiply.MultiplyArmy(50);
        }
    }

    public void ResetGame()
    {
        Money.ResetMoney();
        Multiply.ResetMultiply();
        UpdateAge.ResetAge();
        Wood.ResetWood();
        Farm.ResetFarm();
        Food.ResetFood();
        Manpower.ResetMan();
        VilitsoMinor.Reset();
        Tombekiya.Reset();
        Serborot.Reset();
        Toliviya.Reset();
    }

    public void ExitGame()
    {
        _manager.LoadSceneByName("MainMenu");
    }
}
