using UnityEngine;
using System.Collections;

public class MainCameraController : MonoBehaviour {
	void Start() {
		// 안드로이드 자바클래스 호출
		AndroidManager.Instance.Activity.Call("testEchoMethod", "message", "유니티에서 안드로이드로 보낸 메시지입니다.");
	}
	
	void OnGUI() {
		GUI.Label(new Rect(20f, 50f, 400f, 80f), AndroidManager.Instance.getAndroidLog());
	}
}
