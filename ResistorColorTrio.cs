enum Color
{
    black= 0,
    brown= 1,
    red=2,
    orange= 3,
    yellow= 4,
    green= 5,
    blue= 6,
    violet= 7,
    grey= 8,
    white= 9
}
public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        var first = (int)Enum.Parse(typeof(Color), colors[0]);
        var second = (int)Enum.Parse(typeof(Color), colors[1]);
        var trd = (int)Enum.Parse(typeof(Color), colors[2]);
        string nulls = new string('0', trd);
        ulong oms = (ulong)(first * 10 + second) * (ulong)Math.Pow(10, trd);
        if (oms >= 1000000000)
        {
            return $"{oms / 1000000000.0} gigaohms";
        }
        if (oms >= 1000000)
        {
            return $"{oms / 1000000.0} megaohms";
        }
        if (oms >= 1000)
        {
            return $"{oms / 1000.0} kiloohms";
        }
        else
            return $"{oms} ohms"; 
    }
}
