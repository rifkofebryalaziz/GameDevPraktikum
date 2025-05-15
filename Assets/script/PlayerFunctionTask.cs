using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunctionTask : MonoBehaviour
{
    public int playerHealth = 100;
    public int playerArmor = 20;
    public int playerDamage = 50;

    public string GetPlayerStatus()
    {
        if (playerHealth > 75)
            return "Sehat";
        else if (playerHealth > 30)
            return "Luka Ringan";
        else if (playerHealth > 0)
            return "Kritis";
        else
            return "Mati";
    }

    public int CalculateEffectiveDamage()
    {
        int effectiveDamage = playerDamage - playerArmor;
        return Mathf.Max(effectiveDamage, 0); // Menghindari nilai negatif
    }

    public bool IsPlayerAlive()
    {
        return playerHealth > 0;
    }

    void Start()
    {
        Debug.Log("Status Pemain: " + GetPlayerStatus());
        Debug.Log("Damage Efektif: " + CalculateEffectiveDamage());
        Debug.Log("Apakah Pemain Hidup? " + IsPlayerAlive());
    }
}
