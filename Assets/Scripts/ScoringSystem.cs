﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
   public GameObject scoreText;
   public static int Score;
   //public AudioSource collectSound;

   void Update()
   {
       //collectSound.play();
       scoreText.GetComponent<Text>().text = "SCORE: " + Score;
   }
}
