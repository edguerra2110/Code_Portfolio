/**********************************************************************************
 * Program Name: arith.s
 * Programmer: <your name here>
 * Class: CSCI 2160-001
 * Lab: Lab 9 - C + GAS
 * Date: <date of completion>
 * Purpose: Demonstrate how to create ARM GNU procedures -- also, how mult, div,
 *          add with carry, and sub with borrow work
 *********************************************************************************/

.syntax unified

.text

.align 4

@ Example of addition with a carry--useful for arbitrarily-large arithmetic
@ Let's add a 96-bit number (referenced in r0) to itself and return a 128-bit number (referenced in r1 initially)

/* double96BitNumber: expects two parameters -- r0 -> first byte of 96-bit number to double and r1 -> first byte of 128-bit result */

.type double96BitNumber, %function
.global double96BitNumber

double96BitNumber:
        @ let's use r4-r7 to hold our scratch work--but the ABI dictates we preserve r4-r11 if used...
        PUSH    {r4-r7}

        @ load up r4, r5, and r6 with our 96-bit number
        LDR     r4, [r0], #4
        LDR     r5, [r0], #4
        LDR     r6, [r0]

        @ clear out r7--not involved with the original number
        EOR     r7, r7

        @ do the math
        ADDS    r4, r4, r4
        ADCS    r5, r5, r5
        ADCS    r6, r6, r6
        ADCS    r7, r7, r7

        @ store the sum to the location specified by r1
        STR     r4, [r1], #4
        STR     r5, [r1], #4
        STR     r6, [r1], #4
        STR     r7, [r1]

        @ restore register context
        POP     {r4-r7}
        BX      lr

@ Example of subtraction with carry (borrow)--also useful for arbitrarily-large arithmetic
@ Let's subtract two 64-bit numbers (minuend--the left-hand number--in r1:r0, subtrahend--the right-hand number--in r3:r2)

.type subWithCarry, %function
.global subWithCarry

subWithCarry:
        SUBS    r0, r0, r2
        SBCS    r1, r1, r3
        BX      lr

@ Example of unsigned multiplication--expects two 32-bit operands in r0 and r1

.type unsignedMultiply, %function
.global unsignedMultiply

unsignedMultiply:
        @ UMULL will not work with rdLo, rdHi, and rm being the same -- let's move rm
        MOV     r2, r0

        @ result stored in r1:r0 pair
        UMULL   r0, r1, r2, r1

        @ return to caller
        BX      lr

@ Example of unsigned division

.type unsignedDivide, %function
.global unsignedDivide

unsignedDivide:
        UDIV    r0, r0, r1
        BX      lr

@ Example of unsigned modulo

.type unsignedModulo, %function
.global unsignedModulo

unsignedModulo:
        @ get the quotient
        UDIV    r2, r0, r1

        @ Euclidean division: dividend = divisor * quotient + remainder
        @ Rearranged: remainder = dividend - (divisor * quotient)
        @ r0 holds remainder; r2 is quotient, r1 is divisor, r0 is dividend
        MLS     r0, r2, r1, r0
        BX      lr

/* TODO: add your own function to conditionally add or subtract two parameters--return the sum if even; else, return the difference (first param - second param) */
.type conditionalAddSub, %function
.global conditionalAddSub

conditionalAddSub:
        ADD r2, r0, r1                  //add parameters
        AND r2, #1
        CMP r2, #1                              //and r2 with 1 to check if it is odd
        BEQ odd                                 //branch if the number is odd
even:
        ADD r3, r0, r1
        MOV r0, r3                              //move r3 to r0
        B       NOMAS                           // b to nomas
odd:
        SUB r3, r1, r0
        MOV r0, r3
NOMAS:
        BX      lr
.end
