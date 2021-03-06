// Cleaner version of the bowling scoring function that 
// handles strikes and spares with a single pattern match.
let rec score frames =
    if frames = [] then 0 else
    match Seq.sum frames.Head with
    | 10 -> frames 
            |> Seq.concat 
            |> Seq.truncate 3 
            |> Seq.sum 
    | x -> x
    + score frames.Tail

// Tweetable version (112 characters)
let rec s f=if f=[]then 0 else(Seq.sum f.Head|>function|10->Seq.concat f|>Seq.truncate 3|>Seq.sum|x->x)+s f.Tail

// Load and run our tests
#load "bowling_test.fsx"
open bowling_test 
test score
test s
