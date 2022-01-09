package com.calculator

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.LayoutInflater
import com.calculator.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private var bindingClass: ActivityMainBinding? = null
    private var a: Double = 0.0
    private var b: Double = 0.0
    private var sign: Char = ' '
    private var finish: Boolean = false

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        bindingClass = ActivityMainBinding.inflate(layoutInflater)

        setContentView(bindingClass?.root)

        bindingClass?.textViewDisplay?.text = a.toString()

        bindingClass?.buttonClear?.setOnClickListener {
            a = 0.0
            b = 0.0
            sign = ' '
            finish = false
            bindingClass?.textViewDisplay?.text = a.toString()
        }

        bindingClass?.buttonEqual?.setOnClickListener {
            when (sign) {
                '+' -> a += b
                '-' -> a -= b
                '*' -> a *= b
                '/' -> a /= b
            }

            sign = ' '
            finish = true
            b = 0.0
            bindingClass?.textViewDisplay?.text = a.toString()
        }

        bindingClass?.buttonPlus?.setOnClickListener {
            sign = '+'
            bindingClass?.textViewDisplay?.text = b.toString()
        }

        bindingClass?.buttonMinus?.setOnClickListener {
            sign = '-'
            bindingClass?.textViewDisplay?.text = b.toString()
        }

        bindingClass?.buttonMultiply?.setOnClickListener {
            sign = '*'
            bindingClass?.textViewDisplay?.text = b.toString()
        }

        bindingClass?.buttonDiversion?.setOnClickListener {
            sign = '/'
            bindingClass?.textViewDisplay?.text = b.toString()
        }

        bindingClass?.buttonZero?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 0
                }
                else
                    a = 0.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 0
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonOne?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 1
                }
                else
                    a = 1.0

                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 1
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonTwo?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 2
                }
                else
                    a = 2.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 2
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonThree?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 3
                }
                else
                    a = 3.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 3
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonFour?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 4
                }
                else
                    a = 4.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 4
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonFive?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 5
                }
                else
                    a = 5.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 5
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonSix?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 6
                }
                else
                    a = 6.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 6
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonSeven?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 7
                }
                else
                    a = 7.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 7
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonEight?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 8
                }
                else
                    a = 8.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 8
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }

        bindingClass?.buttonNine?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish) {
                    a *= 10
                    a += 9
                }
                else
                    a = 9.0
                bindingClass?.textViewDisplay?.text = a.toString()
            }
            else
            {
                b *= 10
                b += 9
                bindingClass?.textViewDisplay?.text = b.toString()
            }
        }
    }
}