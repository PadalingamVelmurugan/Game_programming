using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    void Start()
    {
      int playermaxhealth = 100;
      int currenthealth = 50;
      float minhealthreq = 75;
      if (currenthealth < minhealthreq)
      {
        Debug.Log("Ready for battle!");
    
      }
      else
      {
        Debug.Log("You must rest...");
      }
      int mana = 100;
      int spellcost= 50;
      if ( mana > spellcost)
      {
        Debug.Log(" You're a wizard Harry");
      }
      else
      {
        Debug.Log("You need more potiosn");
      }
       
    }

}