package com.lifecycleactivity

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    var textView: TextView? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        textView = findViewById(R.id.textViewDisplay)

        textView?.text = "onCreate"
        Log.i("LifeCycleActivity", "onCreate");
    }

    override fun onStart() {
        super.onStart()

        textView?.text = "onStart"
        Log.i("LifeCycleActivity", "onStart");
    }

    override fun onResume() {
        super.onResume()

        textView?.text = "onResume"
        Log.i("LifeCycleActivity", "onResume");
    }

    override fun onPause() {
        super.onPause()

        textView?.text = "onPause"
        Log.i("LifeCycleActivity", "onPause");
    }

    override fun onStop() {
        super.onStop()

        textView?.text = "onStop"
        Log.i("LifeCycleActivity", "onStop");
    }

    override fun onDestroy() {
        super.onDestroy()

        textView?.text = "onDestroy"
        Log.i("LifeCycleActivity", "onDestroy");
    }
}