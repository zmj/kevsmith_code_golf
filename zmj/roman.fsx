#!/usr/bin/env -S dotnet fsi

let numerals =
    [ "M"; "CM"; "D"; "CD"; "C"; "XC"; "L"; "XL"; "X"; "IX"; "V"; "IV"; "I" ]

let values = [ 1000; 900; 500; 400; 100; 90; 50; 40; 10; 9; 5; 4; 1 ]

let canHasDigit n (v, d) =
    if n - v >= 0 then Some(n - v, d) else None

let digit n =
    List.pick (canHasDigit n) (List.zip values numerals)

let rec convert (n, s) =
    if n = 0 then s else s + convert (digit n)

for line in System.IO.File.ReadLines(fsi.CommandLineArgs[1]) do
    printfn "%s" (convert (int line, ""))
