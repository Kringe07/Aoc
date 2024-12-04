Console.WriteLine($"Part 2: {Part2()}");

int Part2()
{
    var input = File.ReadLines($"{Environment.CurrentDirectory}/input.txt").Select(l => l.ToCharArray()).ToArray();
    var ans = 0;
    for (var x = 0; x < input.Length; x++)
    for (var y = 0; y < input[1].Length; y++)
        if (input[x][y] == 'A' && x - 1 >= 0 && y - 1 >= 0 && x + 1 < input.Length && y + 1 < input.Length)
            if (Math.Abs(input[x + 1][y + 1] - input[x - 1][y - 1]) is 6 && Math.Abs(input[x - 1][y + 1] - input[x + 1][y - 1]) is 6)
                ans++;
    return ans;
}