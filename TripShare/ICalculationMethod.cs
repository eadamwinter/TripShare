﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface ICalculationMethod
    {
        Dictionary<string, decimal> CalculateMembersExpenses(Calculation calculation);
        Dictionary<string, decimal> OptimizeDict(Dictionary<string, decimal> dict);
    }
}
