#pragma once

#include "Field.h"

typedef struct point_t 
{
	int x;
	int y;
} point_t;

public class Player abstract
{
public:
	Player();
	~Player();
	virtual void MakeMove(Field<int> *field) = 0;
protected:
	int side = 0;
};

public class Human : public Player
{
public:
	Human(int side);
	~Human();
	void MakeMove(Field<int> *field);
private:
};

public class StupidBot : public Player
{
public:
	StupidBot(int side);
	~StupidBot();
	void MakeMove(Field<int> *field);
private:
};