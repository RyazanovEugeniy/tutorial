#include <cstdlib>

#include "Player.h"

Player::Player() { }

Player::~Player() { }

Human::Human(int side)
{
	this->side = side;
}

Human::~Human() { }

void Human::MakeMove(Field<int> *field)
{

}

StupidBot::StupidBot(int side) 
{ 
	this->side = side;
}

StupidBot::~StupidBot() { }

void StupidBot::MakeMove(Field<int> *field)
{
	point_t availableMoves[9];
	int counter = 0;

	for (int i = 0; i < field->GetHeight(); i++)
	{
		for (int j = 0; j < field->GetWidth(); j++)
		{
			if (field->GetFieldItem(i, j) == 0)
			{
				availableMoves[counter] = { i, j };
				counter++;
			}
		}
	}

	if (counter != 0)
	{
		int choosen = rand() % counter;
		field->SetFieldItem(availableMoves[choosen].x, availableMoves[choosen].y, side);
		/*System::Diagnostics::Debug::WriteLine("x == " + availableMoves[choosen].x +
											  " y == " + availableMoves[choosen].y +
											  " side == " + side + 
											  " int choosen == " + choosen);*/
	}
}