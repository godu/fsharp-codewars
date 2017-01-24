namespace CodeWars
 
module HowMuchILoveYou =
    let howMuchILoveYou petals =
        match petals % 6 with
        | 1 -> "I love you"
        | 2 -> "a little"
        | 3 -> "a lot"
        | 4 -> "passionately"
        | 5 -> "madly"
        | _ -> "not at all"
