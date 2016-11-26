using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BCLottery
/// </summary>
public class BCLottery
{
    Random random = new Random();
    private int[] lottery;

    public int[] DrawLoteryRows(int numbers, int maxValue)
    {
        lottery = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            int nextNumber;
            do
            {
                nextNumber = random.Next(1, maxValue);
            } while (lottery.Contains(nextNumber));

            lottery[i] = nextNumber;
        }
        Array.Sort(lottery);
        return lottery;
    }
}