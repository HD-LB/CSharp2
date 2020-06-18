using System;

namespace Replace
{
   class Replace
   {
      static string Render(string markdown)
      {
         var splitByUpper = markdown.Split(new[] { "**" }, StringSplitOptions.RemoveEmptyEntries);
         for (int i = 1; i < splitByUpper.Length; i += 2)
         {
            splitByUpper[i] = splitByUpper[i].ToUpper();

         }

         var splitByLower = string.Concat(splitByUpper).Split(new[] { '`' },StringSplitOptions.RemoveEmptyEntries);
         for (int i = 1; i < splitByLower.Length; i += 2)
         {
            splitByLower[i] = splitByLower[i].ToLower();

         }
         return string.Concat(splitByUpper);
         return string.Concat(splitByLower);
      }
      static void Main()
      {
         var markdown = @"# String processing tasks 

                - **Manipulating strings - comparing, concatanating, searching, extracting, splitting * *
                - `Comparison` 
                - What is lexicographic comparison
                - Brief showcase of string.Compare
                - _Live demo_: Compare strings by given priority of letters
                - `Concatanating` 
                - Brief showcase Concat
                - `Searching` 
                - _Live demo_: Find all occurences of a given substring
                - `Substring and extracting strings` 
                - Brief showcase substring method
                - _Live demo_: Extract all comments from code
                - `Splitting` 
                - Brief showcase split method
                - _Live demo_: Read input for a problem
                - _Live demo_: Extract comments from code
                - _Live demo_: Count occurences of a string
                - **Other operations * *
                - `Replacing substrings` 
                - Brief showcase replace method
                - _Live demo_: Sanitize input against XSS
                - _Live demo_: Censorship
                - `Case transformations` 
                - Brief showcase upper and lowercase methods
                - _Live demo_: Parse md - like thing
                - `Trimming` 
                - _Live demo_: Remove leading zeros from a number
                - _Live demo_: Trim spaces from html
                - Bonus: Padding
                - Showcase PadLeft and PadRight
                - **Building and Modifying strings * *
                - `StringBuilder` 
                - _Live demo_: Compress a string
                - _Live demo_: Decompress a string
                - **Formatting strings * *
                - `String interpolation` 
                - Brief showcase
                - `String.Format` 
                - Brief showcase
                - **Cultures and Culture - Sensitive Formatting * *
                - **TODO * *
                - `Parsing Numbers and Dates` 
                - _Live demo_: Parse a date by hand by a given format
                - _Live demo_: Compare custom parse to buil -in int.Parse";
               

         Console.WriteLine(Render(markdown));
      }
   }
}
