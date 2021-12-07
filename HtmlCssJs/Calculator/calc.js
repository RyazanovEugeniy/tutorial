let a = '0';
let b = '';
let sign = '';
let finish = false;

const digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.'];
const action = ['-', '+', '*', '/'];

const out = document.querySelector('.calc-screen p');

function clearAll() 
{
    a = '0';
    b = '';
    sign = '';
    finish = false;
}

document.querySelector('.buttons').onclick = (event) => 
{
    if (!event.target.classList.contains('btn'))
        return;

    const text = event.target.textContent;

    if (text === 'ac')
    {
        clearAll();
        out.textContent = a;
        return;
    }

    if (text === '%')
    {
        if (sign == '')
        {
            a = 0;
            out.textContent = a;
        }
        else
        {
            b = a * b / 100;
            out.textContent = b;
        }
    }

    if (text === '+/-')
    {
        if (sign == '')
        {
            a *= -1;
            out.textContent = a;
        }
        else
        {
            b *= -1;
            out.textContent = b;
        }
    }

    if (digit.includes(text))
    {
        if (sign == '')
        {
            if (finish == false && a != 0)
                a += text;
            else
                a = text;
            out.textContent = a;
        }
        else
        {
            if (b != 0)
                b += text;
            else
                b = text;
            out.textContent = b;
        }
    }
    
    if (action.includes(text))
    {
        sign = text;
        out.textContent = sign;
    }

    if (text === '=')
    {
        switch (sign) 
        {
            case '*':
                a *= b;
                break;
            case '/':
                if (b != 0)
                    a /= b;
                else
                {
                    clearAll();
                    out.textContent = 'error';
                    return;
                }
                break;
            case '+':
                a = (+a) + (+b);
                break;
            case '-':
                a -= b;
                break;
            default:
                break;
        }

        out.textContent = a;
        finish = true;
        b = '';
        sign = '';
    }
}