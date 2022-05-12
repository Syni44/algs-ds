# https://www.hackerrank.com/challenges/fp-array-of-n-elements/problem?h_r=profile
# 11-04-2021

defmodule Solution do
  input = IO.read(:stdio, :all)
  |> String.to_integer
  
  1..input |> Enum.to_list |> IO.inspect(limit: :infinity)
end
