let a = '0';
let b = '';
let sign = '';
let finish = false;

const digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.'];
const action = ['-', '+', '*', '/'];

const out = document.querySelector('.calc-screen p');

function clearAll() {
    a = '0';
    b = '';
    sign = '';
    finish = false;
}

document.querySelector('.buttons').onclick = (event) => 
{
    out.textContent = a;

    if (!event.target.classList.contains('btn'))
        return;

    if (event.target.classList.contains('ac'))
    {
        clearAll();
        return;
    }

    const key = event.target.textContent;

    if (digit.includes(key))
    {
        if (sign == '')
        {
            if (finish == false && a != 0)
                a += key;
            else
                a = key;
            out.textContent = a;
        }
        else
        {
            if (b != 0)
                b += key;
            else
                b = key;
            out.textContent = b;
        }
    }
    
    if (action.includes(key))
    {
        sign = key;
        out.textContent = sign;
    }

    if (key === '=')
    {
        switch (sign) {
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
        }

        out.textContent = a;
        finish = true;
        b = '';
        sign = '';
    }
}