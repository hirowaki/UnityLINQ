# UnityLINQ
#### Unity 5.4

* C#|Unity|LINQ usage samples comparing to Javascript (lodash/underscore)
* Observer pattern using UniRX.

Sample cases.
```C#
            switch (testNum++) {
            case 1:
                // _.filter in JS.
                var filtered = source.Where(i => ((i & 1) == 0));
                result = FormatResult("Where", filtered);  // => 0, 2, 4, 8, 10
                break;
            case 2:
                // _.map in JS.
                var mapped = source.Select(i => (i << 1));
                result = FormatResult("Select", mapped);  // => 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20
                break;
            case 3:
                // _.take / _.slice in JS. taking the three elements from the head.
                var takenHead = source.Take(3);
                result = FormatResult("Take", takenHead);  // => 0, 1, 2
                break;
            case 4:
                // _.filter(a => a < 5)
                var takenWhile = source.TakeWhile(i => i < 5);
                result = FormatResult("TakeWhile", takenWhile);  // => 0, 1, 2, 3, 4
                break;
            case 5:
                // takenWhile would break the loop right away when the condition fails. 
                var takenWhile2 = source.TakeWhile(i => ((i & 1) == 0));
                result = FormatResult("TakeWhile", takenWhile2);  // => 0.
                break;
            case 6:
                // _.head.
                var first = source.First();
                result = FormatResult("First", first);  // => 0
                break;
            case 7:
                // First can have a condition.
                var first2 = source.First(i => i > 2);
                result = FormatResult("First", first2);  // => 3
                break;
            case 8:
                // FirstOrDefault.
                var firstD = source.FirstOrDefault(i => i > 100);   // no such elements in the souce.
                result = FormatResult("FirstOrDefault", firstD);  // => 0. then default<T>(=> 0) would come.
                break;
            case 9:
                // Count.
                var count = source.Count();
                result = FormatResult("Count", count);  // 10
                break;
            case 10:
                // Count. (_.filter().length).
                var count2 = source.Count(i => ((i & 1) != 0));
                result = FormatResult("Count", count2); // 5
                break;
            case 11:
                // _.every.
                var all = source.All(i => (i < 1000));  // all elements would satisfy this condition.
                result = FormatResult("All", all);  // True
                break;
            case 12:
                // _.isEmpty.
                var any = source.Any();
                result = FormatResult("Any", any);  // True
                break;
            case 13:
                // _.some.
                var some = source.Any(i => (i > 100));    // no elements will satisfy the condition (i > 100).
                result = FormatResult("Any", some);  // False.

                testNum = -1;
                break;
            }

```

#### external references

Plugin
* [UniRX](https://github.com/neuecc/UniRx)

Javascript
* [lodash](https://lodash.com/)
* [underscore](http://underscorejs.org/)


