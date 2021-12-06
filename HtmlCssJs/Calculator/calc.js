let a = '';
let b = '';
let sign = '';
let finish = false;

const digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.'];
const action = ['-', '+', '*', '/'];

const out = document.querySelector('.calc-screen p');

function clearAll() {
    a = '';
    b = '';
    sign = '';
    finish = false;
    out.textContent = 0;
}

document.querySelector('.buttons').onclick = (event) => 
{
    out.textContent = '';

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
            if (finish == false)
                a += key;
            else
                a = key;
            out.textContent = a;
        }
        else
        {
            b += key;
            out.textContent += b;
        }
    }
    
    if (action.includes(key))
    {
        sign = key;
        out.textContent = sign;
    }

    if (event.target.classList.contains('equal'))
    {
        if (sign === '*')
            a *= b;
        if (sign === '/')
        {
            if (b != 0)
                a /= b;
            else
            {
                out.textContent = 'null';
                return;
            }
        }
        if (sign === '+')
            a += b;
        if (sign === '-')
            a -= b;

        out.textContent = a;
        finish = true;
        b = '';
        sign = '';
    }
}