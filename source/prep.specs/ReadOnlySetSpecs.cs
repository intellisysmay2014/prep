using System.Collections.Generic;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using prep.collections;

namespace prep.specs
{
  class ReadOnlySetSpecs
  {
    internal class concern_for_readonly_set : Observes<IEnumerable<int>, ReadOnlySet<int>>
    {
    }

    public class when_iterating_a_read_only_set : concern_for_readonly_set
    {
      //Do your setup here
      Establish c = () =>
      {
        depends.on<IEnumerable<int>>(new List<int> {1, 2, 3, 4});
        numbers = new List<int>();
      };

      //Invoke the functionality you are testing here
      Because b = () =>
      {
        foreach (var item in sut)
          numbers.Add(item);
      };

      //Make assertions in one or many it blocks
      It should_iterate_all_of_the_items_it_was_provided = () =>
        numbers.ShouldContain(1, 2, 3, 4);

      static List<int> numbers;
    }

    public class when_getting_the_Enumerable : concern_for_readonly_set
    {
    }

  }
}