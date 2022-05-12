# https://www.hackerrank.com/challenges/fp-filter-array/problem?h_r=profile
# 11-03-2021

defmodule Solution do
  [delim | elements] = IO.read(:stdio, :all)
  |> String.split("\n")
  
  Enum.each(elements, fn e ->
    cond do
      String.to_integer(e) < String.to_integer(delim) ->
        IO.write(:stdio, e <> "\n")
      true -> :ok
    end
  end)
end