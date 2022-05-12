# https://leetcode.com/problems/contains-duplicate/
# Nov 2021

defmodule Solution do
  @spec contains_duplicate(nums :: [integer]) :: boolean
  def contains_duplicate(nums) do
    nums != Enum.uniq(nums)
  end
end