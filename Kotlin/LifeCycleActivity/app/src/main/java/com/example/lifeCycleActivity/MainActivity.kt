package com.example.lifeCycleActivity

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.TextView

class MainActivity : AppCompatActivity() {



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        Log.d("LifeCycleActivity", "onCreate")

        val textViewState = findViewById<TextView>(R.id.textViewState)
        textViewState.text = "onCreate"
    }

    override fun onStart() {
        super.onStart()
        Log.d("LifeCycleActivity", "onStart")

        val textViewState = findViewById<TextView>(R.id.textViewState)
        textViewState.text = "onStart"
    }

    override fun onResume() {
        super.onResume()
        Log.d("LifeCycleActivity", "onResume")

        val textViewState = findViewById<TextView>(R.id.textViewState)
        textViewState.text = "onResume"
    }

    override fun onPause() {
        super.onPause()
        Log.d("LifeCycleActivity", "onPause")

        val textViewState = findViewById<TextView>(R.id.textViewState)
        textViewState.text = "onPause"
    }

    override fun onStop() {
        super.onStop()
        Log.d("LifeCycleActivity", "onStop")

        val textViewState = findViewById<TextView>(R.id.textViewState)
        textViewState.text = "onStop"
    }

    override fun onDestroy() {
        super.onDestroy()
        Log.d("LifeCycleActivity", "onDestroy")

        val textViewState = findViewById<TextView>(R.id.textViewState)
        textViewState.text = "onDestroy"
    }
}