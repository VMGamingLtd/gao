using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class Planet0Buildings
{
    public static float Planet0Index = 28.18f;
    public static int AtmospherePlanet0 = 90;
    public static int AgriLandPlanet0 = 23;
    public static int ForestsPlanet0 = 41;
    public static int WaterPlanet0 = 51;
    public static int FisheriesPlanet0 = 28;
    public static int MineralsPlanet0 = 18;
    public static int RocksPlanet0 = 35;
    public static int FossilFuelsPlanet0 = 13;
    public static int RareElementsPlanet0 = 6;
    public static int GemstonesPlanet0 = 11;
    public static int HousingUnityPlanet0 = 0;
    public static int OxygenGeneratorPlanet0 = 0;
    public static int AtmosphericCondenserPlanet0 = 0;

    public static string AddBuildingCount(ref int buildingName, int amount)
    {
        buildingName += amount;
        return buildingName.ToString();
    }

    public static string ReduceBuildingCount(ref int buildingName, int amount)
    {
        buildingName -= amount;
        return buildingName.ToString();
    }

    public static string ResetBuildingCount(ref int buildingName)
    {
        buildingName = 0;
        return buildingName.ToString();
    }

    public static float CalculatePlanet0Index()
    {
    int condition1 = Planet0Buildings.AtmospherePlanet0;
    int condition2 = Planet0Buildings.AgriLandPlanet0;
    int condition3 = Planet0Buildings.ForestsPlanet0;
    int condition4 = Planet0Buildings.WaterPlanet0;
    int condition5 = Planet0Buildings.FisheriesPlanet0;
    int condition6 = Planet0Buildings.MineralsPlanet0;
    int condition7 = Planet0Buildings.RocksPlanet0;
    int condition8 = Planet0Buildings.FossilFuelsPlanet0;
    int condition9 = Planet0Buildings.RareElementsPlanet0;
    int condition10 = Planet0Buildings.GemstonesPlanet0;

    float result = (float)Math.Round((condition1 + condition2 + condition3 + condition4 + condition5 + condition6 + condition7 + condition8 + condition9 + condition10) / 11.0f, 1);
    Planet0Buildings.Planet0Index = result;
    return result;
    }
}