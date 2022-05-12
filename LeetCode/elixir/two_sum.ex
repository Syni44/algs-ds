# https://leetcode.com/problems/two-sum/
# Nov 2021

defmodule Solution do
  @spec two_sum(nums :: [integer], target :: integer) :: [integer]
  def two_sum(nums, target) do
    list = Enum.with_index(nums)

    for i <- list, j <- list, uniq: true, into: [] do
      case (elem(i, 0) + elem(j, 0) == target) do
        true when i != j and elem(j, 1) > elem(i, 1) ->
          [elem(i, 1)] ++ [elem(j, 1)]
        _ ->
          nil
      end
    end
      
    |> List.last
  end
end