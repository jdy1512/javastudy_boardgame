package com.javastudy.boardgame;

import android.os.Bundle;

import com.javastudy.boardgame.tag.TagManager;
import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;


public class EclipseBasicActivity extends UnityPlayerActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        
    }
    
    public void testEchoMethod(String tag, String message) {
    	UnityPlayer.UnitySendMessage(TagManager.UNITY3D_RECEIVER_CLASS, "setLogByAndroid", "echo : [" + tag + "]" + message);
    }
    
}