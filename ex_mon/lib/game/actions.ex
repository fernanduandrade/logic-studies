defmodule ExMon.Game.Actions do
  alias ExMon.Game

  def fetchMove(move) do
    Game.player()
    |> Map.get(:moves)
    |> findMoves(move)
  end

  defp findMoves(moves, move) do
    Enum.find_value(moves, {:error, move}, fn {key, value} ->
      if value == move, do: {:ok, key}
    end)
  end
end
