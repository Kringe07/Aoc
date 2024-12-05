var rules = new List<(int, int)>();
var groups = new List<List<int>>();
var sw = false;

foreach (var line in File.ReadLines($"{Environment.CurrentDirectory}/input.txt"))
{
    var part = line.Split('|');
    if (part[0] == "")
    {
        sw = true;
        continue;
    }
    if (sw)
        groups.Add(line.Split(',').Select(int.Parse).ToList());
    else
        rules.Add((int.Parse(part[0]), int.Parse(part[1])));
}

var total = 0;
foreach (var group in groups)
{
    var valid = true;
    var groupRules = new List<(int, int)>();
    foreach (var rule in rules)
        if (group.Contains(rule.Item1) && group.Contains(rule.Item2))
            groupRules.Add(rule);

    for (var i = group.Count - 2; i > 0; i--)
        valid = valid && !groupRules.Where(r => r.Item1 == group[i]).Any(r => group.GetRange(0, i).Contains(r.Item2));

    if (!valid)
    {
        
    }
}
Console.WriteLine(total);