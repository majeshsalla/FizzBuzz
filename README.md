# FizzBuzz

App Url: https://fizzbuzz20210506222816.azurewebsites.net/

Basic ASP.NET Core Web Application which is deployed to Azure.
This Application takes in collection of Values and prints output once everything is processed.

1. If Value % 3 == 0 prints "Fizz"
2. If Value % 5 == 0 prints "Buzz"
3. If Value % 3 == 0 && Value % 5 == 0  prints "FizzBuzz"
4. Prints the operations performed for a number which does not satisy above conditions.
5. Prints "Invalid Item" if it is a non numeric value


Assumptions: 
User may enter any collection of values but the application will process values which are integers and ranged in b/w Int64.Min (-9223372036854775808) and Int64.Max (9223372036854775808)