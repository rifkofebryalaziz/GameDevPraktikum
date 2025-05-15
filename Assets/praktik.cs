using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class praktik : MonoBehaviour
{
    public int Health = 100;
    public float speed = 5.5f;
    bool isAlive = true;
    string playerName = "Player1";
    char grade = 'A';

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ContonCorotine());
    }
    
    IEnumerator ContonCorotine()
    {
        Debug.Log("Mulai Corotine");
        yield return new WaitForSeconds(5f);
        Debug.Log("Corotine Selesai");
    }




}
