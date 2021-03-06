//Created by Neodrop
//mailto : neodrop@unity3d.ru
using UnityEngine;
//#pragma warning disable

public class VizioWindowInspectorEditor : VizioWindowInspector
{
    //[MenuItem("Antares/VIZIO/Open Inspector")]
    public static void CreateNewWindow()
    {
        window = GetWindow<VizioWindowInspectorEditor>();
        if (window == null)
            return;
        window.title = "INSPECTOR";
        window.minSize = new Vector2(512, 256);
        window.wantsMouseMove = true;
    }
}
