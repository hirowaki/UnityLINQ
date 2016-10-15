using UnityEngine;
using System.Collections;
using UniRx;

public class MainScene : MonoBehaviour {
    private string _result = "START";

    // static.
    private static GUIStyle _guiStyle = new GUIStyle();
    private static Rect _guiRect = new Rect();
    private static Color _colorWhite = new Color(1, 1, 1, 1);

    void Start () {
        Observable.FromCoroutine <string> (observer => LinqTest.RunningSamples (observer))
            .Subscribe (
                // kinda Promise(resolve(args)) in JS. (But Rx and Promise are not the same).
                result => {
                    _result = result;
                },
                () => {
                    _result="COMPLETED";
                }
            );
    }

    void OnGUI() {
        _guiStyle.fontSize = 32;
        _guiStyle.normal.textColor = _colorWhite;
        _guiStyle.alignment = TextAnchor.MiddleCenter;

        _guiRect.width = 128;
        _guiRect.height = 32;
        _guiRect.x = Screen.width / 2 - _guiRect.width / 2;;
        _guiRect.y = Screen.height / 2 - _guiRect.height / 2;;

        GUI.Label(_guiRect, _result, _guiStyle);
    }
}
