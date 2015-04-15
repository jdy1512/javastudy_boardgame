using UnityEngine;
using System.Collections;

public class AndroidManager : MonoBehaviour {
	private static AndroidManager _instance;
	private AndroidJavaObject activity;

	private string androidLog = "No Log";

	// Singleton pattern
	public static AndroidManager Instance {
		get {
			if (_instance == null) {
				_instance = FindObjectOfType(typeof(AndroidManager)) as AndroidManager;
				if (_instance == null) {
					_instance = new GameObject("AndroidManager").AddComponent<AndroidManager>();
				}
			}
			return _instance;
		}// end of get
	}// end of getInstance()

	void Awake() {
		// 현재 실행 중인 유니티 액티비티를 가져와서 변수에 저장
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		activity = jc.GetStatic<AndroidJavaObject>("currentActivity");
	}

	// ------------------------------------------------------------------------------------

	// Android 클래스가 호출하는 메소드들

	public void setLogByAndroid(string newAndroidLog) {
		androidLog = newAndroidLog;
	}

	// ------------------------------------------------------------------------------------
	
	public AndroidJavaObject Activity {
		get {
			return activity;
		}
	}

	public string getAndroidLog() {
		return androidLog;
	}
}
