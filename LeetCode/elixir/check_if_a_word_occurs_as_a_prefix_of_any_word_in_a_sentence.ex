# https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
# May 10 2022

defmodule Solution do
  @spec is_prefix_of_word(sentence :: String.t, search_word :: String.t) :: integer
  def is_prefix_of_word(sentence, search_word) do
    String.split(sentence, " ", trim: true)
    |> Enum.find_index(fn s -> String.starts_with?(s, search_word) end)
    |> case do
         nil -> -1
         result -> result + 1
    end    
  end
end