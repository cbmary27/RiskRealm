using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class pay1 : MonoBehaviour
{
    string city;
    public TextMeshProUGUI c;
    public TextMeshProUGUI a;
    string[] fire_arr = { "Mumbai", "Germany", "Manila", "Tokyo", "Carribean Islands" };
    int index;
    public static List<string> asset_removed = new List<string>();
    public void Score_up()
    {
        if (Risks1.rt == 1)
        {
            c.text = "Mumbai!";
            city = "Mumbai";
            asset_in(city, Checkbox_1.FLOOD, Checkbox_1.NO_FLOOD);

        }
        if (Risks1.rt == 2)
        {
            index = Random.Range(0, fire_arr.Length);
            c.text = fire_arr[index] + "!";
            city = fire_arr[index];
            asset_in(city, Checkbox_2.FIRE, Checkbox_2.FIRE);
        }
        if (Risks1.rt == 3)
        {
            c.text = "Mumbai!";
            city = "Mumbai";
            asset_in(city, Checkbox_3.TSUNAMI, Checkbox_3.NO_TSUNAMI);
        }
        if (Risks1.rt == 4)
        {
            c.text = "Mumbai!";
            city = "Mumbai";
            asset_in(city, Checkbox_6.TYPHOON, Checkbox_6.NO_TYPHOON);

        }
    }

    public void asset_in(string city, List<string[]> insure_asset, List<string[]> no_risk)
    {
        int count = 0;
        int count1 = 0;
        int k = 0;
        List<string> asset_i = new List<string>();
        List<string> a_removed = new List<string>();
        for (int i = 0; i < Show_Assets2.show1.Count; i++)
        {

            if (string.Compare(Show_Assets2.show1[i][1], city) == 0)
            {
                asset_i.Add(Show_Assets2.show1[i][0]);
            }
        }
        a.text = "";
        if (asset_i.Count == 0)
        {
            a.text = "You have no assets established in " + city + ".";
        }
        /*for(int i = 0;i<insure_asset.Count; i++)
        {
            a.text += insure_asset[i][0] + insure_asset[i][1];
        }*/
        for (int i = 0; i < asset_i.Count; i++)
        {
            count = 0;
            count1 = 0;
            a.text += "Assets: " + asset_i[i] + "\n";
            for (int j = 0; j < insure_asset.Count; j++)
            {
                if (asset_i[i] == insure_asset[j][0] && city == insure_asset[j][1])
                {
                    a.text += "This asset is insured." + "\n";
                    count++;
                    count1++;
                }
            }
            if (count == 0)
            {
                while (k < no_risk.Count)
                {
                    if (asset_i[i] == no_risk[i][0] && city == no_risk[i][1])
                    {
                        a.text += "This asset is safe!" + "\n";
                        count1++;
                    }
                    k++;
                }
                if (count1 == 0)
                {
                    a.text += "This asset was not insured." + "\n";
                    a_removed.Add(asset_i[i]);
                    for (int n = 0; n < Checkbox_1.FLOOD.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_1.FLOOD[n][0])
                        {
                            Checkbox_1.FLOOD.RemoveAt(n);
                        }
                    }
                    for (int n = 0; n < Checkbox_4.EARTHQUAKE.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_4.EARTHQUAKE[n][0])
                        {
                            Checkbox_4.EARTHQUAKE.RemoveAt(n);
                        }
                    }
                    for (int n = 0; n < Checkbox_2.FIRE.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_2.FIRE[n][0])
                        {
                            Checkbox_2.FIRE.RemoveAt(n);
                        }
                    }
                    for (int n = 0; n < Checkbox_6.TYPHOON.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_6.TYPHOON[n][0])
                        {
                            Checkbox_6.TYPHOON.RemoveAt(n);
                        }
                    }
                    for (int n = 0; n < Checkbox_7.THUNDERSTORM.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_7.THUNDERSTORM[n][0])
                        {
                            Checkbox_7.THUNDERSTORM.RemoveAt(n);
                        }
                    }
                    for (int n = 0; n < Checkbox_3.TSUNAMI.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_3.TSUNAMI[n][0])
                        {
                            Checkbox_3.TSUNAMI.RemoveAt(n);
                        }
                    }
                    for (int n = 0; n < Checkbox_8.HURRICANE.Count; n++)
                    {
                        if (asset_i[i] == Checkbox_8.HURRICANE[n][0])
                        {
                            Checkbox_8.HURRICANE.RemoveAt(n);
                        }
                    }
                }
            }
        }
        for (int i = 0; i < Show_Assets2.show1.Count; i++)
        {
            for (int j = 0; j < a_removed.Count; j++)
            {
                if (string.Compare(a_removed[j], Show_Assets2.show1[i][0]) == 0)
                {
                    pay1.asset_removed.Add(a_removed[j]);
                    Show_Assets2.show1.RemoveAt(i);
                }
            }
        }
        for (int i = 0; i < Show_Assets2.show.Count; i++)
        {
           for(int v = 0; v < a_removed.Count; v++)
            { 
                if (string.Compare(Show_Assets2.show[i][0], a_removed[v]) == 0)
                {
                    Show_Assets2.show[i][1] = "Damaged";
                }
            }
        }
        asset_i.Clear();

    }
}

