# https://www.hackerrank.com/challenges/fp-list-replication/problem?h_r=profile
# 11-03-2021

defmodule Solution do
  #Enter your code here. Read input from STDIN. Print output to STDOUT
  [times | elements] = IO.read(:stdio, :all)
  |> String.split("\n")
  
  times = String.to_integer(times)
  Enum.each(elements, fn str ->
    for _ <- 1..times, do: IO.write(:stdio, str <> "\n")
  end)
end