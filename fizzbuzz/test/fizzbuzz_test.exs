defmodule FizzbuzzTest do
  use ExUnit.Case

  describe "build/1" do
    test "when a file is valid it returns the converted list" do
      expectedResponse = {:ok,
      [1, 2, :fizz, 4, :buzz, :fizz, 7, 8, :fizz, :buzz, 11, :fizz, 13, 14, :fizzbuzz, 16, 17, :buzz, :buzz, :fizzbuzz,
       :fizzbuzz]}
      assert Fizzbuzz.build("number.txt") == expectedResponse
    end

    test "when an file is invalid it returns an error" do
      expectedResponse = {:error, "Error while trying to read the file: enoent"}
      assert Fizzbuzz.build("invalid.txt") == expectedResponse
    end
  end
end
