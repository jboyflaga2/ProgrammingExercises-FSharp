// feb 31, 2017

//open System.Math


// let binding
module DemoModule = 
    let someFunction = 
        let a = 1
        let b = 2
        a * b



let aString ="this is a string"
let aInt = 12
let aDecimal = 12.444
//let aPiFunction () = Math.PI
//let aSquareRootFunction (x) = Math.Sqrt(x)
//let aFullyTypedSquareRootFunction (x :float) = Math.Sqrt(x)
let a,b = "a","tuple"



// use binding
use sw = new StreamWriter(@"c:\temp\fprintfFile.txt")
fprintf sw "This is a string line %s\r\n" "cat"
fprintf sw "This is a int line %i" 10
sw.Close()

let Write callback =
    use sw = new StreamWriter(@"c:\temp\fprintfFile.txt")
    fprintf sw "Write is writing to the StreamWriter"
    callback sw
    sw
 
// the use binding only works with IDisposable
let callback sw = fprintf sw "sw is the StreamWriter"
let disp = Write callback