using UnityEngine;
using System.Collections;

public class MainScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LinqTest.RunningSamples();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private static GUIStyle _guiStyle = new GUIStyle();
    private static Rect _guiRect = new Rect();
    private static Color _colorWhite = new Color(1, 1, 1, 1);

    static GUIStyle GetGUIStyle() {
        return _guiStyle ?? (_guiStyle = new GUIStyle());
    }

    void OnGUI() {
        GetGUIStyle().fontSize = 32;
        GetGUIStyle().normal.textColor = _colorWhite;
        GetGUIStyle().alignment = TextAnchor.MiddleCenter;

        Rect rect = _guiRect;
        rect.width = 128;
        rect.height = 32;
        rect.x = Screen.width / 2 - rect.width / 2;;
        rect.y = Screen.height / 2 - rect.height / 2;;

        GUI.Label(rect, "Sample", GetGUIStyle());
    }
}
