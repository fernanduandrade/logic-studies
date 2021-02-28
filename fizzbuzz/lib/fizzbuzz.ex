defmodule Fizzbuzz do
  def build(fileName) do
    fileName
    |> File.read()
    |> fileHandler()
  end

  defp fileHandler({:ok, result}) do
    result =
      result
      |> String.split(",")
      |> Enum.map(&convetAndEvaluate/1)
    {:ok, result}
  end

  defp fileHandler({:error, reason}), do: {:error, "Error while trying to read the file: #{reason}"}

  defp convetAndEvaluate(element) do
    element
    |> String.to_integer()
    |> evalueteNumber()
  end

  defp evalueteNumber(number) when rem(number, 3) == 0 and rem(number, 5) == 0, do: :fizzbuzz
  defp evalueteNumber(number) when rem(number, 3) == 0, do: :fizz
  defp evalueteNumber(number) when rem(number, 5) == 0, do: :buzz

  defp evalueteNumber(number), do: number

end
