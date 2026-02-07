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
    public TMP_InputField username;
    public string uname;
   
    public void save_username()
    {
        uname=username.text;
        board[i] = uname;
    }
  }
