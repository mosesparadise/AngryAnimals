# AngryAnimals
Pi's father, Danny, runs the Hackerville Zoo. He is moving to Rookieville and wants to take all of the zoo animals with him via ship. He is confused about how to arrange them because a few of the species cannot be kept together in the same cabin.

There are n animals placed in a straight line. Each animal is identified
by a unique number from 1 to n in order. There are m pairs (a[i], b[i])
which imply that animals a[i] and b[i] are enemies and should not be
kept in the same cabin. Pi is good at solving problems and he came up
with following challenge: count the number of different groups that
do not contain any pair such that they are enemies. A group is defined
as an interval (x, y) such that all animals in the range from x to y form a
group. Determine the number of groups that can be formed according
to the Pi's challenge.


# For example 
Given n = 3 animals and m = 3 pairs of enemies, a = [1, 2,
3] and b = [3, 3, 1], animal 1 is the enemy of animal 3, and animal 3 is
the enemy of animals 1 and 2. Because 3 is an enemy of both 1 and 2, it
must be in its own cabin. Animals 1 and 2 can be roomed together or
separately. There are four possible groupings meeting the constraints:
{1, 2} , {1}, {2}, {3}. Note that the intervals are along the original line of
animals numbered consecutively from 1 to n, i.e. [1, 2, 3] in this case.
They cannot be reordered.

# Function Description
Complete the function angryAnimals in the editor below. The function
must return the number of groups that can be formed according to Pi's
challenge.
angryAnimals has the following parameters:

n: an integer that denotes the number of unique animals

a[a[0],...a[m-1]]: an array of integers

b[b[0],...b[m-1]]: an array of integers
