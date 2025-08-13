#!/usr/bin/env -S dotnet fsi
let rec c(n,s)=if n=0 then s else s+c(List.pick(fun(v,d)->if n-v>=0 then Some(n-v,d) else None)(List.zip [1000;900;500;400;100;90;50;40;10;9;5;4;1] ["M";"CM";"D";"CD";"C";"XC";"L";"XL";"X";"IX";"V";"IV";"I"]))
for l in System.IO.File.ReadLines fsi.CommandLineArgs[1] do printfn"%s"(c(int l,""))
