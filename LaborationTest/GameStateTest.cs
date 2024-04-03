using System;
using Xunit;
using Laboration;

namespace LaborationTest 
{ 

public class GameStateTest
{
    [Fact]
   public void CheckForWin_NoWinner_EmptyBoard()
    {
        var gameState = new GameState();
        var result = gameState.CheckForWin();
        Assert.Equal(GameState.WinState.No_Winner, result);
    }

    [Fact]
    public void Check_TieGame()
    {
        var gameState = new GameState();

        for(int i = 0; i < 42; i++) 
        {
            gameState.TheBoard[i] = i % 2 + 1;
        }

        var result = gameState.CheckForWin();

        Assert.Equal(GameState.WinState.Tie, result);
        }
    }

}