#pragma once

#include "Player.h"
#include "Field.h"

ref class Game
{
public:
	Game(Player* player1, Player* player2, int fieldSize);
	~Game();

    Field<int>* GetField();
	int CheckWinCondition();

private:
	Player* player1;
	Player* player2;
	Field<int>* field;
};


