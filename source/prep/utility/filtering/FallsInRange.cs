﻿using System;
using prep.utility.ranges;

namespace prep.utility.filtering
{
  public class FallsInRange<T> :IMatchAn<T> where T : IComparable<T>
  {
    IContainValues<T> range;

    public FallsInRange(IContainValues<T> range)
    {
      this.range = range;
    }

    public bool matches(T item)
    {
      return range.contains(item);
    }
  }
}