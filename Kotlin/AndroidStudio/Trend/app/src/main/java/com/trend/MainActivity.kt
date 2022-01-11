package com.trend

import com.trend.databinding.ActivityMainBinding
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.graphics.Canvas
import android.graphics.Color
import android.graphics.drawable.ShapeDrawable
import android.graphics.drawable.shapes.RectShape
import android.graphics.Bitmap
import android.graphics.drawable.BitmapDrawable
import android.graphics.drawable.shapes.OvalShape

class MainActivity : AppCompatActivity() {
    private var bindingClass: ActivityMainBinding? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        bindingClass = ActivityMainBinding.inflate(layoutInflater)

        setContentView(bindingClass?.root)

        val bitmap: Bitmap = Bitmap.createBitmap(700, 1000, Bitmap.Config.ARGB_8888)
        val canvas = Canvas(bitmap)

        var left = 100
        var top = 100
        var right = 600
        var bottom = 400

        var shapeDrawable = ShapeDrawable(RectShape())
        shapeDrawable.setBounds(left, top, right, bottom)
        shapeDrawable.paint.color = Color.parseColor("#009944")
        shapeDrawable.draw(canvas)

        left = 100
        top = 500
        right = 600
        bottom = 800

        shapeDrawable = ShapeDrawable(OvalShape())
        shapeDrawable.setBounds(left, top, right, bottom)
        shapeDrawable.paint.color = Color.parseColor("#009191")
        shapeDrawable.draw(canvas)

        bindingClass?.imageV?.background = BitmapDrawable(resources, bitmap)
    }
}