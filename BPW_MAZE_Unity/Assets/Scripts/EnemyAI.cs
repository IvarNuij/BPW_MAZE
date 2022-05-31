using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerScript;

public class EnemyAI : MonoBehaviour
{
    //Refrences
    PlayerScript player;

    private void Start()
    {
        //Refrences
        player = FindObjectOfType<PlayerScript>();
        //Sub to OnNextTurn
        player.OnNextTurn += AI;
    }

    private void OnDestroy()
    {
        //Unsub from OnNextTurn
        player.OnNextTurn -= AI;
    }



    public void AI()
    {

    }
}