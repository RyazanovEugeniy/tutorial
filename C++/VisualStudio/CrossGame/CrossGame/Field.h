#pragma once

template <typename T>
class Field
{
private:
    T** Matrix;
    int height;
    int width;

public:
    Field(int height, int width)
    {
        this->height = height;
        this->width = width;

        Matrix = (T**) new T * [height];

        for (int i = 0; i < height; i++)
            Matrix[i] = (T*) new T[width];

        for (int i = 0; i < height; i++)
            for (int j = 0; j < width; j++)
                Matrix[i][j] = 0;
    }

    Field(const Field& field)
    {
        height = field.height;
        width = field.width;

        field = (T**) new T * [height];

        for (int i = 0; i < height; i++)
            field[i] = (T*) new T[width];

        for (int i = 0; i < height; i++)
            for (int j = 0; j < width; j++)
                field[i][j] = field.Matrix[i][j];
    }

    T GetFieldItem(int i, int j)
    {
        if ((height > 0) && (width > 0))
            return Matrix[i][j];
        else
            return 0;
    }

    void SetFieldItem(int i, int j, T value)
    {
        if ((i < 0) || (i >= height))
            return;
        if ((j < 0) || (j >= width))
            return;
        Matrix[i][j] = value;
    }

    int GetHeight()
    {
        return height;
    }

    int GetWidth()
    {
        return width;
    }

    Field operator=(const Field& M)
    {
        if (width > 0)
        {
            for (int i = 0; i < height; i++)
                delete[] Matrix[i];
        }

        if (height > 0) 
            delete[] Matrix;

        height = M.height;
        width = M.width;

        Matrix = (T**) new T * [height];
        for (int i = 0; i < height; i++)
            Matrix[i] = (T*) new T[width];

        for (int i = 0; i < height; i++)
            for (int j = 0; j < width; j++)
                Matrix[i][j] = M.Matrix[i][j];
        return *this;
    }

    ~Field()
    {
        if (width > 0)
            for (int i = 0; i < height; i++)
                delete[] Matrix[i];

        if (height > 0)
            delete[] Matrix;
    }
};