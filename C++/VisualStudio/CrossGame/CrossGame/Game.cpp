#include "Game.h"

Game::Game(Player* player1, Player* player2, int fieldSize)
{ 
	this->player1 = player1;
	this->player2 = player2;

	field = new Field<int>(fieldSize, fieldSize);
	
	int counter = 0;
	while (this->CheckWinCondition() == 0 && counter < 9)
	{
		if (counter % 2 == 0)
			player1->MakeMove(field);
		else
			player2->MakeMove(field);
		counter++;
	}

	//System::Diagnostics::Debug::WriteLine("CheckWinCondition == " + this->CheckWinCondition());
}

Game::~Game() 
{ 
	if (field != nullptr)
		delete field;
}

Field<int>* Game::GetField()
{
	/*for (int i = 0; i < field->GetHeight(); i++)
	{
		for (int j = 0; j < field->GetWidth(); j++)
			System::Diagnostics::Debug::Write(field->GetFieldItem(i, j) + " ");
		System::Diagnostics::Debug::WriteLine("");
	}*/
	
	return field;
}

int Game::CheckWinCondition()
{
	if (field == nullptr)
		return 0;

	// Проверяем строки
	for (int i = 0; i < field->GetHeight(); i++)
	{
		bool stateChanged = false;
		int firstItem = field->GetFieldItem(i, 0);

		for (int j = 0; j < field->GetWidth(); j++)
			if (field->GetFieldItem(i, j) != firstItem)
				stateChanged = true;

		if (stateChanged == false)
			return firstItem;
	}
	
	// Проверяем столбцы
	for (int j = 0; j < field->GetWidth(); j++)
	{
		bool stateChanged = false;
		int firstItem = field->GetFieldItem(0, j);

		for (int i = 0; i < field->GetHeight(); i++)
			if (field->GetFieldItem(i, j) != firstItem)
				stateChanged = true;

		if (stateChanged == false)
			return firstItem;
	}

	// Проверяем прямую диагональ
	bool stateChanged = false;
	int firstItem = field->GetFieldItem(0, 0);

	for (int i = 0; i < field->GetHeight(); i++)
		if (field->GetFieldItem(i, i) != firstItem)
			stateChanged = true;

	if (stateChanged == false)
		return firstItem;

	// Проверяем обратную диагональ
	stateChanged = false;
	firstItem = field->GetFieldItem(field->GetHeight() - 1, 0);

	for (int i = 0; i < field->GetHeight(); i++)
		if (field->GetFieldItem(field->GetHeight() - 1 - i, i) != firstItem)
			stateChanged = true;

	if (stateChanged == false)
		return firstItem;

	return 0;
}
