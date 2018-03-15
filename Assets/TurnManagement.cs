using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManagement : MonoBehaviour {

    public List<Player> Players;
    private int count = 0;
	// Use this for initialization
	void Start ()
    {
        ChangeTurn();
	}
	
   public void ChangeTurn()
    {
        SetEveryoneOff();
        Players[count++ % Players.Count].SetOn();
    }

   void SetEveryoneOff()
    {
        foreach (Player player in Players)
        {
            player.SetOff();
        }
    }
}
