namespace F_Calculator_RCE

open Microsoft.VisualBasic.CompilerServices


type Result<'TSuccess,'Tstring> =
    |Success of 'TSuccess
    |Fail of message: string
   
type ResultBuilder(ErrorMessage:string) =
     member b.Zero()=Error ErrorMessage
     member b.Bind(x,f)=
         match x with
         |Success x -> f x
         |Fail message -> "error"
     member b.Return x = Success x
     member b.Combain(x,f)= f x
     
module Calculator_RCE =
    
    type Operations =
    |Plus
    |Minus
    |Mult
    |Divide
    |UnknownOperation
    
    let result = ResultBuilder("error")
    let DivideByZero =
        "can not divided by zero"
    let WrongOperator =
        "this operator does not exist"
        
    let Calculate (var1: decimal) (var2:decimal) operation =
       match operation with
         |Plus -> Success (var1 + var2)
         |Minus -> Success(var1 - var2)
         |Mult -> Success (var1 * var2)
         |Divide ->
             if var2 = 0m then
                 Fail "can not divided by zero"
             else
                 Success (var1 / var2)
         |UnknownOperation -> Fail "this operator does not exist"
         
