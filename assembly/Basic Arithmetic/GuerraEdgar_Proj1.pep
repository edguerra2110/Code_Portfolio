;******************************************************************************************************************
;*       Program Name:       Pep/9 Calculator
;*       Programmer:         Edgar Guerra
;*       Class:              CSCI 2160-001
;*       Lab:                Project 1
;*       Purpose:            Create a program that allows users to input a function and out put the result
;******************************************************************************************************************
BR       main                                 ;branch around our global variables
in1:             .BLOCK 2                     ;holds first input of the function so we can perform a calculation with it later on
in2:             .BLOCK 2                     ;holds second input of the function so we can perform a calculation with it later on
solution:        .BLOCK 2                     ;holds the solution    
main:            STRO        instruct,d       ;prints out instructions on how to use the calculator.  
                 LDBA        0,i              ;load in 0 to a so that we can reset all our variables
                 STWA        in1,d            ;set first input to 0
                 STWA        in2,d            ;set second input to 0
                 STWA        solution,d       ;set solution to 0
                 DECI        in1,d            ;assume first value is formatted correctly so read it in as DECI
                 STWA        charOut,d
parse:           LDBA        charIn,d         ;load in the first char
                 CPBA        ' ',i            ;if its a space
                 BREQ        parse            ;go back to beginning and read in the next character 
                 CPBA        'q',i            ;is it a q
                 BREQ        isQuit           ;branch to quit if not equal
isPlus:          CPBA        '+',i            ;is it a +
                 BRNE        isMinus          ;branch was not equal so we check if its a minus sign 
                 DECI        in2,d            ;tak in the decimal value   
                 LDWA        in2,d            ;add value2 to accumulator
                 ADDA        in1,d            ;add value1 + value2
                 STWA        solution,d       ;store the solution 
                 BR          prntSol          ;end program
isMinus:         CPBA        '-',i            ;is it a -
                 BRNE        isAND	      ;branch to AND if not equal
                 DECI        in2,d            ;read in the second input
                 LDWA        in1,d            ;load the first input
                 SUBA        in2,d            ;subtract the first input from the last
                 STWA        solution,d	      ;store answer in solution
                 BR          prntSol          ;branch to print solution
isAND:           CPBA        '&',i            ;is it a &
                 BRNE        isOR             ;branch to or if not equal
                 LDWA        in1,d            ;load in the first input 
                 DECI        in2,d            ;take second input
                 ANDA        in2,d            ;and the first input with the second
                 STWA        solution,d       ;store the answer 
                 BR          prntSol
isOR:            CPBA        '\|',i           ;is it a |
                 BRNE        isLessT          ;branch to is less than if not equal
                 DECI        in2,d            ;read in second input
                 LDWA        in1,d            ;load in first input   
                 ORA         in2,d	       ;preform or operation with input 1 and 2
                 STWA        solution,d	      ;store the solution 
                 BR          prntSol          ;break to print solution

isLessT:         CPBA        '<',i            ;is it a <
                 BRNE        isGreatT         ;if its not equal then branch to greater than
                 LDWA        in1,d            ;else load in the first input
                 DECI        in2,d            ;read in second input
                 CPWA        in2,d            ;compare input 1 and 2
                 BRLT        setTrue          ;if it is less than set solution to true and output solution
                 LDWA        0,i              ;else set solution equal to 0 for false
                 STWA        solution,d       ;store A in solution
                 BR          prntSol          ;Break to print solution
                 
isGreatT:        CPBA        '>',i            ;is it a >
                 BRNE          isEqual        ;if its not equal then branch to is equal
                 LDWA        in1,d            ;load in the first input   
                 DECI        in2,d            ;read in the second input
                 CPWA        in2,d            ;compare input 1 and 2
                 BRGT        setTrue          ;if it is greater then set to true
                 LDWA        0,i              ;else set to 0 
                 STWA        solution,d       ;set solution = a
                 BR          prntSol          ;branch to print the solution
isEqual:         CPBA        '=',i            ;is it a =
                 BRNE        dispErro         ;branch to is less than
                 LDWA        in1,d            ;load first input
                 DECI        in2,d            ;read in second input
                 CPWA        in2,d            ;compare input 1 and 2
                 BREQ        setTrue          ;if it is equal than set it to true
                 LDWA        0,i              ;else set solution equal to false 
                 STWA        solution,d       ;store solution 
                 BR          prntSol          ;branch to print the solution
dispErro:        STRO        error,d          ;function was put in wrong
                 BR          main             ;branch back to main
setTrue:         LDWA         1,i             ;set A to 1 to represent true
                 STWA        solution,d       ;store the value in solution
prntSol:         DECO        solution,d       ;display the solution
                 LDBA        '\n',i           ;read in more input to look for termination
                 STBA        charOut,d        ;print new line 
                 STBA        charOut,d        ;print new line 
                 CPBA        '\n',i           ;if its a new line character
                 BREQ        main             ;branch to main
isQuit:          STOP
instruct:         .ASCII  "Please type in a number, operand, followed by another number delimited with a space to preform a calculation. e.g. \"7 \| 2\" \n\n\x00"
error:            .ASCII "Please type in a function formatted like this: 1 & 0, 1 + 2, 1 - 2, 1 \| 1 \n\n\x00"
                 .END
         