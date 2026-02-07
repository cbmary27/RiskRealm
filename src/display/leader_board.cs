using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
public class leader_board : MonoBehaviour
{
    
   public TextMeshProUGUI disp_score, U1,S1;


public void display_score()
    {
        for(int i = 0;i<Show_Assets2.show1.Count;i++)
        {
            sum += int.Parse(Show_Assets2.show1[i][2]);
        }
        for(int i =0;i<Show_Assets2.show.Count;i++)
        {
            isum += int.Parse(Show_Assets2.show[i][2]);
        }
        xf = sum;
        xi = isum;
        yf = Show_Assets2.keep;
        yi = xi * 5 / 100;
        score = ((xf / xi) * 1000) + ((yf / yi) * 1000);
        disp_score.text = "SCORE : " + score.ToString();
         U1.text=leader board.uname; 
S1.text =score.ToString();
    }
}
