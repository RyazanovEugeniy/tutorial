package com.calculator

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.calculator.databinding.ActivityMainBinding
import kotlin.math.pow
import kotlin.math.sqrt

class MainActivity : AppCompatActivity() {
    private var bindingClass: ActivityMainBinding? = null
    private var a: String = "0"
    private var b: String = "0"
    private var sign: Char = ' '
    private var finish: Boolean = false

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        bindingClass = ActivityMainBinding.inflate(layoutInflater)

        setContentView(bindingClass?.root)

        bindingClass?.textViewDisplay?.text = a

        bindingClass?.buttonClear?.setOnClickListener {
            a = "0"
            b = "0"
            sign = ' '
            finish = false
            bindingClass?.textViewDisplay?.text = a
        }

        bindingClass?.buttonEqual?.setOnClickListener {
            when (sign) {
                '+' -> a = (a.toDouble() + b.toDouble()).toString()
                '-' -> a = (a.toDouble() - b.toDouble()).toString()
                '*' -> a = (a.toDouble() * b.toDouble()).toString()
                '/' -> a = (a.toDouble() / b.toDouble()).toString()
            }

            sign = ' '
            finish = true
            b = "0"
            bindingClass?.textViewDisplay?.text = a
        }

        bindingClass?.buttonPow2?.setOnClickListener {
            b = "0"
            sign = ' '
            finish = true
            a = a.toDouble().pow(2.0).toString()
            bindingClass?.textViewDisplay?.text = a
        }

        bindingClass?.buttonSqrtX?.setOnClickListener {
            a = sqrt(a.toDouble()).toString()
            b = "0"
            sign = ' '
            finish = true
            bindingClass?.textViewDisplay?.text = a
        }

        bindingClass?.buttonPlus?.setOnClickListener {
            sign = '+'
        }

        bindingClass?.buttonMinus?.setOnClickListener {
            sign = '-'
        }

        bindingClass?.buttonMultiply?.setOnClickListener {
            sign = '*'
        }

        bindingClass?.buttonDiversion?.setOnClickListener {
            sign = '/'
        }

        bindingClass?.buttonChangeSign?.setOnClickListener {
            if (sign == ' ')
            {
                a = (a.toDouble() * (-1.0)).toString()
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                b = (b.toDouble() * (-1.0)).toString()
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonZero?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "0"
                }
                else
                    a = "0"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "0"
                else
                    b = "0"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonOne?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "1"
                }
                else
                    a = "1"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "1"
                else
                    b = "1"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonTwo?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "2"
                }
                else
                    a = "2"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "2"
                else
                    b = "2"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonThree?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "3"
                }
                else
                    a = "3"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "3"
                else
                    b = "3"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonFour?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "4"
                }
                else
                    a = "4"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "4"
                else
                    b = "4"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonFive?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "5"
                }
                else
                    a = "5"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "5"
                else
                    b = "5"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonSix?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "6"
                }
                else
                    a = "6"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "6"
                else
                    b = "6"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonSeven?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "7"
                }
                else
                    a = "7"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "7"
                else
                    b = "7"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonEight?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "8"
                }
                else
                    a = "8"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "8"
                else
                    b = "8"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonNine?.setOnClickListener {
            if (sign == ' ')
            {
                if (!finish && a != "0") {
                    a += "9"
                }
                else
                    a = "9"
                bindingClass?.textViewDisplay?.text = a
            }
            else
            {
                if (b != "0")
                    b += "9"
                else
                    b = "9"
                bindingClass?.textViewDisplay?.text = b
            }
        }

        bindingClass?.buttonPoint?.setOnClickListener {
            if (sign == ' ')
            {
                if (!a.contains(".")) {
                    a += "."
                    bindingClass?.textViewDisplay?.text = a
                }
            }
            else
            {
                if (!b.contains(".")) {
                    b += "."
                    bindingClass?.textViewDisplay?.text = b
                }
            }
        }
    }
}