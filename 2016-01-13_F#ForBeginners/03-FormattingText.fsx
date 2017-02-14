// incorrect type
//printfn "should be a decimal value %d" "cat"
//this works
printfn "should be a decimal value %d" 42
// incorrect type but works
Console.WriteLine("should be a decimal value {0}" , "cat")
 
 
// wrong number of parameters provided
//printfn "this only expected 1 arg of type decimal %d" 42 "dog"
// wrong number of parameters provided but works
Console.WriteLine("this only expected 1 arg of type decimal {0}" , 42, "dog")
// this works as expected
printfn "this only expected 2 args of type decimal %d and string %s" 42 "dog"
 

/////////////////////////////////////////////////////
// bprintf - Prints to a StringBuilder.

open System.Text

let builder = new StringBuilder(524288)
Printf.bprintf builder "This will be a string line : %s\r\n" "cat"
Printf.bprintf builder "This will be a bool line : %b\r\n" true
Printf.bprintf builder "This will be a int line : %u\r\n" 42
Printf.bprintf builder "This will be a hex line : %X\r\n" 255
 
printfn "%s" (builder.ToString())



//////////////////////////////////////////////////////
// fprintf - Prints to a text writer.

open System.IO

use sw = new StreamWriter(@"c:\temp\fprintfFile.txt")
 
fprintf sw "This is a string line %s\r\n" "cat"
fprintf sw "This is a int line %i" 10
 
sw.Close()


//////////////////////////////////////////////////////
// sprintf - Prints to a string by using an internal string buffer and returns the result as a string. Helper printers must return strings.

let result = Printf.sprintf "This will return a formatted string : %s\r\n" "cat"
printfn "%s" result