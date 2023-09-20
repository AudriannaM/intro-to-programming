namespace StringCalculator;



public class StringCalculator
{



    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        var nums = numbers.Split(',');
        var result = 0;
        foreach (var x in nums)
        {
            var newnums = int.Parse(x);
            //var newNum = 1 + 2; Just an example
            result = result + newnums;
        }
        return result;
    }
}
