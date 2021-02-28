defmodule ExMon.Game.Status do
  alias ExMon.Game
  def printMessage() do
    IO.puts("\n==== The game is started! ====\n")
    IO.inspect(Game.info())
    IO.puts("---------------")
  end
end
