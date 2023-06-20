open System

let (|InAlphabet|NotInAlphabet|) (character: char) =
    let alphabet = "abcdefghijklmnopqrstuvwxyz"
    let lowerChar = Char.ToLower(character) 
    match character with
    | _ when alphabet.Contains lowerChar  -> InAlphabet (char character)
    | _ -> NotInAlphabet

let getCipher (character: char) (rotate: int) =
    let offSet =
        if Char.IsUpper character then 65 else 97
    let rotateChar = (((int)character + rotate - offSet) % 26 + offSet)
    char rotateChar

let parseChar (character: char) (rotate: int) =
    match character with
    | InAlphabet c -> getCipher c rotate
    | NotInAlphabet -> character


let decrypt (text: string) (rotate: int) =
    let output =
        text
        |> Seq.map(fun c -> parseChar c rotate )
        |> String.Concat |> Seq.map string |> String.concat ""
    output

let cipher = decrypt "CESAR CIPHER DEMO" 5
printfn "%A" cipher