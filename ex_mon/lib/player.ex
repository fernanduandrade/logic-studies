defmodule ExMon.Player do
  @required_keys [:life, :moves, :name]
  @max_life 100

  @enforce_keys @required_keys

  defstruct @required_keys




  def build(moveAvg, moveHeal, moveRng, name) do
    %ExMon.Player{
      life: @max_life,
      moves: %{
        moveAvg: moveAvg,
        moveHeal: moveHeal,
        moveRnd: moveRng,
      },
      name: name
    }
  end
end
