﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Player
    {
        public string Name { get; set; }
        public Dice DiceOne { get; set; }
        public Dice DiceTwo { get; set; }

        public Player()
        {
            DiceOne = new Dice();
            DiceTwo = new Dice();
        }

        public void Play()
        {
            DiceOne.ThrowDice();
            DiceTwo.ThrowDice();
            int numberOfDiceOne = DiceOne.Number;
            int numberOfDiceTwo = DiceTwo.Number;

            Console.WriteLine($"Zar 1 değeri {numberOfDiceOne} ve zar 2 değeri {numberOfDiceTwo}' dir.");
            Score = numberOfDiceOne + numberOfDiceTwo;



        }
        public int Score { get; private set; }

    }
}
