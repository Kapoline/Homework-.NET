namespace F_Calculator

module Calculator =
    
    type Operations =
    |Plus
    |Minus
    |Mult
    |Divide
    |UnknownOperation
    
    let DivideByZero =
        "can not divided by zero"
    let WrongOperator =
        "this operator does not exist"
        
    let Calculate (var1:int) (var2:int) operation =
       match operation with
       |Plus -> var1 + var2
       |Minus -> var1 - var2
       |Mult -> var1 * var2
       |Divide ->
           try
               var1 / var2
           with :? System.DivideByZeroException -> failwith DivideByZero   
       |UnknownOperation -> failwith WrongOperator 