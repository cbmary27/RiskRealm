using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

public class Checkbox_9 : MonoBehaviour
{
    public Toggle checkbox0;
    public Toggle checkbox1;
    public Toggle checkbox2;
    public Toggle checkbox3;
    public Toggle checkbox4;
    public Toggle checkbox5;
    public Toggle checkbox6;
    public Toggle checkbox7;
    public Toggle checkbox8;
    public Toggle checkbox9;
    public Toggle checkbox10;
    public Toggle checkbox11;
    public Toggle checkbox12;
    public Toggle checkbox13;
    public Toggle checkbox14;


    public TextMeshProUGUI text_holder, n0, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14;

    int a;
  int count = 0;

    public static List<string[]> TROPICAL = new List<string[]>();
    public static List<string[]> NO_TROPICAL = new List<string[]>();

    public void Start()
    {

        if (NO_TROPICAL.Count == 0)
        {

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Property", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Mines", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Mumbai" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "Mumbai" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Germany" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Germany" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Germany" });
            NO_TROPICAL.Add(new string[] { "Property", "Germany" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Germany" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Germany" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Germany" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Germany" });
            NO_TROPICAL.Add(new string[] { "Mines", "Germany" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Germany" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Germany" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Germany" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Germany" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Germany" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "Germany" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Manila" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Manila" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Manila" });
            NO_TROPICAL.Add(new string[] { "Property", "Manila" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Manila" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Manila" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Manila" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Manila" });
            NO_TROPICAL.Add(new string[] { "Mines", "Manila" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Manila" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Manila" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Manila" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Manila" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Manila" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "Manila" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Property", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Mines", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "San Francisco" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "San Francisco" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Property", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Mines", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Calgary" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "Calgary" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Property", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Mines", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Gulf of Mexico" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "Gulf of Mexico" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Property", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Tokyo" });
       
            NO_TROPICAL.Add(new string[] { "Power Plants", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Tokyo" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Tokyo" });

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Property", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Mines", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Caribbean Islands" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Caribbean Islands" });
     

            NO_TROPICAL.Add(new string[] { "Heavy Machinery", "Texas" });
            NO_TROPICAL.Add(new string[] { "Heat Exchanger", "Texas" });
            NO_TROPICAL.Add(new string[] { "Pipelines", "Texas" });
            NO_TROPICAL.Add(new string[] { "Property", "Texas" });
            NO_TROPICAL.Add(new string[] { "Manufacturing Plants", "Texas" });
            NO_TROPICAL.Add(new string[] { "Warehouse and Cold Storage", "Texas" });
            NO_TROPICAL.Add(new string[] { "Hotels and Resorts", "Texas" });
            NO_TROPICAL.Add(new string[] { "Supermarkets and Malls", "Texas" });
            NO_TROPICAL.Add(new string[] { "Mines", "Texas" });
            NO_TROPICAL.Add(new string[] { "Power Plants", "Texas" });
            NO_TROPICAL.Add(new string[] { "Oil Refineries", "Texas" });
            NO_TROPICAL.Add(new string[] { "Telecom Towers", "Texas" });
            NO_TROPICAL.Add(new string[] { "Aircrafts", "Texas" });
            NO_TROPICAL.Add(new string[] { "Ships and Cargo", "Texas" });
            NO_TROPICAL.Add(new string[] { "Fleets and Cars", "Texas" });
        }
    }




    public void check_val_0()
    {

   

        //-------------------------------------------------------------
        //Heavy machinery
        //-------------------------------------------------------------


        if (checkbox0.isOn)
        {


            if (Show_Assets2.show[0][1] == "Damaged")
            {
                n0.text = "DAMAGED";
                checkbox0.isOn = false;
            }
            else
            {
                n0.text = "No policy available";
                checkbox0.isOn = false;
            }
        }

        else if (!checkbox0.isOn)
        {



        }
    }
    //---------------------------------------------------
    //Heat Exchanger
    //-------------------------------------------------------
    public void check_val_1()
    {

   


        if (checkbox1.isOn)
        {
             if (Show_Assets2.show[1][1] == "Damaged")
            {
                n1.text = "DAMAGED";
                checkbox1.isOn = false;
            }
            else
            {
                n1.text = "No policy available";
                checkbox1.isOn = false;
            }
        }

        else if (!checkbox1.isOn)
        {


        }


    }
    //-----------------------------------------------------------
    //pipelines
    //-----------------------------------------------------------

    public void check_val_2()
    {

   

        if (checkbox2.isOn)
        {
            if (Show_Assets2.show[2][1] == "Damaged")
            {
                n2.text = "DAMAGED";
                checkbox2.isOn = false;
            }
            else
            {
                n2.text = "No policy available";
                checkbox2.isOn = false;
            }

        }

        else if (!checkbox2.isOn)
        {


        }

    }

    //-----------------------------------------------------------
    //property
    //-----------------------------------------------------------

    public void check_val_3()
    {


        if (checkbox3.isOn)
        {
            if (Show_Assets2.show[3][1] == "Damaged")
            {
                n3.text = "DAMAGED";
                checkbox3.isOn = false;
            }
            else
            {
                n3.text = "No policy available";
                checkbox3.isOn = false;
            }

        }

        else if (!checkbox3.isOn)
        {

         

        }


    }

    //-----------------------------------------------------------
    //manufacturing plants
    //-----------------------------------------------------------

    public void check_val_4()
    {
        if (checkbox4.isOn)
        {
            if (Show_Assets2.show[4][1] == "Damaged")
            {
                n4.text = "DAMAGED";
                checkbox4.isOn = false;
            }
            else
            {
                n4.text = "No policy available";
                checkbox4.isOn = false;
            }
        }
    }


    //-----------------------------------------------------------
    //warehouse and cold storage
    //-----------------------------------------------------------

    public void check_val_5()
    {



        if (checkbox5.isOn)
        {
            if (Show_Assets2.show[5][1] == "Damaged")
            {
                n5.text = "DAMAGED";
                checkbox5.isOn = false;
            }
            else
            {
                n5.text = "No policy available";
                checkbox5.isOn = false;
            }
        }


        else if (!checkbox5.isOn)
        {


        }

    }

    //----------------------------------------------------------------
    //hotels and resorts
    //----------------------------------------------------------------

    public void check_val_6()
    {

     


        if (checkbox6.isOn)
        {
            if (Show_Assets2.show[6][1] == "Damaged")
            {
                n6.text = "DAMAGED";
                checkbox6.isOn = false;
            }
            else
            {
                n6.text = "No policy available";
                checkbox6.isOn = false;
            }

        }

        else if (!checkbox6.isOn)
        {



        }
    }


    //-----------------------------------------------------------
    //supermarkets and malls
    //-----------------------------------------------------------

    public void check_val_7()
    {
     

        if (checkbox7.isOn)
        {
            if (Show_Assets2.show[7][1] == "Damaged")
            {
                n7.text = "DAMAGED";
                checkbox7.isOn = false;
            }
            else
            {
                n7.text = "No policy available";
                checkbox7.isOn = false;
            }

        }

        else if (!checkbox7.isOn)
        {


        }


    }


    //------------------------------------------------------------------
    //Mines
    //-----------------------------------------------------------------

    public void check_val_8()
    {
        count = 0;
        if (TROPICAL.Count != 0)
        {
            for (int i = 0; i < TROPICAL.Count; i++)
            {
                if (TROPICAL[i][0] == "Mines" && TROPICAL[i][1] == "Tokyo" )
                {
                    count++;
                    n8.text = "Policy is already chosen";
                }
            }
        }


        if (checkbox8.isOn && count==0)
        {
            if (Show_Assets2.show[8][1] == "Tokyo")
            {
                a = -30000;
                FindObjectOfType<rem_amount>().change_amount(a);
                TROPICAL.Add(new string[] { "Mines", "Tokyo" });
            }
            else if (Show_Assets2.show[8][1] == "Damaged")
            {
                n8.text = "DAMAGED";
                checkbox8.isOn = false;
            }
            else
            {
                n8.text = "No policy available";
                checkbox8.isOn = false;
            }
        }


        else if (!checkbox8.isOn)
        {
            if (Show_Assets2.show[8][1] == "Tokyo")
            {
                a = 30000;
                FindObjectOfType<rem_amount>().change_amount(a);
            }

        }
    }

    //---------------------------------------------------------
    //Power plants
    //---------------------------------------------------------

    public void check_val_9()
    {
 

        if (checkbox9.isOn)
        {
            if (Show_Assets2.show[9][1] == "Damaged")
            {
                n9.text = "DAMAGED";
                checkbox9.isOn = false;
            }
            else
            {
                n9.text = "No policy available";
                checkbox9.isOn = false;
            }

        }

        else if (!checkbox9.isOn)
        {
        }
    }
    //--------------------------------------------------------
    //Oil refineries
    //--------------------------------------------------------

    public void check_val_10()
    {
     

        if (checkbox10.isOn)
        {
            if (Show_Assets2.show[10][1] == "Damaged")
            {
                n10.text = "DAMAGED";
                checkbox10.isOn = false;
            }
            else
            {
                n10.text = "No policy available";
                checkbox10.isOn = false;
            }

        }

        else if (!checkbox10.isOn)
        {

        }
    }
    //------------------------------------------------------------
    //Telecom towers
    //--------------------------------------------------------------

    public void check_val_11()
    {
       

        if (checkbox11.isOn)
        {
             if (Show_Assets2.show[11][1] == "Damaged")
            {
                n11.text = "DAMAGED";
                checkbox11.isOn = false;
            }
            else
            {
                n11.text = "No policy available";
                checkbox11.isOn = false;
            }
        }

        else if (!checkbox11.isOn)
        {



        }

    }
    //------------------------------------------------------------
    //aircrafts
    //------------------------------------------------------------


    public void check_val_12()
    {
   

        if (checkbox12.isOn)
        {
             if (Show_Assets2.show[12][1] == "Damaged")
            {
                n12.text = "DAMAGED";
                checkbox12.isOn = false;
            }
            else
            {
                n12.text = "No policy available";
                checkbox12.isOn = false;
            }
        }

        else if (!checkbox12.isOn)
        {

        }

    }
    //-------------------------------------------------------------
    //ships and cargo
    //------------------------------------------------------------

    public void check_val_13()
    {
     

        if (checkbox13.isOn)
        {
            if (Show_Assets2.show[13][1] == "Damaged")
            {
                n13.text = "DAMAGED";
                checkbox13.isOn = false;
            }
            else
            {
                n13.text = "No policy available";
                checkbox13.isOn = false;
            }
        }

        else if (!checkbox13.isOn)
        {


        }
    }

    //------------------------------------------------------------
    //Fleets and cars
    //-------------------------------------------------------------

    public void check_val_14()
    {
        count = 0;
        if (TROPICAL.Count != 0)
        {
            for (int i = 0; i < TROPICAL.Count; i++)
            {
                if (TROPICAL[i][0] == "Fleets and Cars" && TROPICAL[i][1] == "Caribbean Islands")
                {
                    count++;
                    n14.text = "Policy is already chosen";
                }
            }
        }


        if (checkbox14.isOn && count==0)
        {
            if (Show_Assets2.show[14][1] == "Caribbean Islands")
            {
                a = -20000;
                FindObjectOfType<rem_amount>().change_amount(a);
                TROPICAL.Add(new string[] { "Mines", "Caribbean Islands" });
            }
            else if (Show_Assets2.show[14][1] == "Damaged")
            {
                n14.text = "DAMAGED";
                checkbox14.isOn = false;
            }
            else
            {
                n14.text = "No policy available";
                checkbox14.isOn = false;
            }
        }


        else if (!checkbox14.isOn)
        {
            if (Show_Assets2.show[14][1] == "Caribbean Islands")
            {
                a = 20000;
                FindObjectOfType<rem_amount>().change_amount(a);
            }

        }
    }


}
