open System

let parseStrToInt str = Int32.Parse str

let rec superDigit (input: string) (times: int): int =
    let finalString =  String.replicate times input
    let sumResult =
        finalString
        |> Seq.map(fun cd -> Int32.Parse(string cd))
        |> Seq.sum
        |> string

    match sumResult.Length with
        |  1 -> parseStrToInt sumResult
        | _ -> superDigit sumResult 1




superDigit "9875" 9999