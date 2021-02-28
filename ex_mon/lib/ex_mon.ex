defmodule ExMon do
  @moduledoc """
  Documentation for ExMon.
  """
  alias ExMon.{Game, Player}
  alias ExMon.Game.{Status, Actions}

  @computerName "BiipBoop"

  def createPlayer(moveAvg, moveHeal, moveRnd, name) do
    Player.build(moveAvg, moveHeal, moveRnd, name)
  end

  def startGame(player) do
    @computerName
    |> createPlayer(:punch, :kick,:heal)
    |> Game.start(player)

    Status.printMessage()
  end

  def makeMove(move) do
    move
    |> Actions.fetchMove()
  end

end
