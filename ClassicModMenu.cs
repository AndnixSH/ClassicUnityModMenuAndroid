//It is better to create own class instead adding OnGUI on existing class.
//You can use this whole code as a new class
using UnityEngine;

public class ModMenuScript : MonoBehaviour {

    public static bool hack1;
    public static bool hack2;
    public static bool hack3;
    public static string string1;
    public static string string2;
    public static string string3;
    public static bool ShowHide = false;

    public static void MyGUI() {

        if (GUI.Button(new Rect(20, 20, 130f, 30f), "SHOW/HIDE"))
        {
            ShowHide = !ShowHide;
        }

        if (ShowHide)
        {
            GUI.Box(new Rect(20, 50, 180, 150), "Your mod menu");
            if (GUI.Button(new Rect(25, 80, 170f, 30f), string1))
            {
                hack1 = !hack1;
            }
            if (GUI.Button(new Rect(25, 115, 170f, 30f), string2))
            {
                hack2 = !hack2;
            }
            if (GUI.Button(new Rect(25, 150, 170f, 30f), string3))
            {
                hack3 = !hack3;
            }
        }

        if (hack1)
        {
            string1 = "Unlimited armor <color=green>ON</color>";
            hack1 = false;
        }
        else
        {
            string1 = "Unlimited armor <color=red>OFF</color>";
            hack1 = true;
        }

        if (hack2)
        {
            string2 = "Unlimited team health <color=green>ON</color>";
            hack2 = false;
        }
        else
        {
            string2 = "Unlimited team health <color=red>OFF</color>";
            hack2 = true;
        }

        if (hack3)
        {
            string3 = "Unlimited coins <color=green>ON</color>";
            hack3 = false;
        }
        else
        {
            string3 = "Unlimited coins <color=red>OFF</color>";
            hack3 = true;
        }
    }
}
