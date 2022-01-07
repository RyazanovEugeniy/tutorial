package com.lifecycleactivity

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        Log.i("LifeCycleActivity", "onCreate");
    }

    override fun onStart() {
        super.onStart()
        Log.i("LifeCycleActivity", "onStart");
    }

    override fun onResume() {
        super.onResume()
        Log.i("LifeCycleActivity", "onResume");
    }

    override fun onPause() {
        super.onPause()
        Log.i("LifeCycleActivity", "onPause");
    }

    override fun onStop() {
        super.onStop()
        Log.i("LifeCycleActivity", "onStop");
    }

    override fun onDestroy() {
        super.onDestroy()
        Log.i("LifeCycleActivity", "onDestroy");
    }
}