module QuickSort.Main

let rec quicksort list =
  match list with
  | [] -> []
  | x :: xs ->
    let smaller = List.filter ((>) x) xs in
    let bigger = List.filter ((<) x) xs in
      quicksort smaller @ [x] @ quicksort bigger;

printfn "%A" (quicksort [2;4;200;30;8;121;14;35;20;30])

