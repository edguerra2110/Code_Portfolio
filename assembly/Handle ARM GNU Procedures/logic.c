/**********************************************************************************
 * Program Name: logic.c
 * Programmer: Edgar Guerra
 * Class: CSCI 2160-001
 * Lab: Lab 9 - C + GAS
 * Date: <date of completion>
 * Purpose: Demonstrate how to call ARM assembly subroutines from C driver
 *********************************************************************************/

#include "logic.h"

int inlineAND (int x, int y) {
    // this snippet will AND together x and y, outputting to z
    int z;

    // general format here {this is optional}: asm {volatile}(code: output operand list : input operand list :$
    asm("ANDS     %[result], %[lhs], %[rhs]"    /* AND x and y together, store in z */
               : [result]"=r"   (z)             /* result from AND stored in z */
               : [lhs]"r"       (x),            /* left hand operand for AND */
                 [rhs]"r"       (y)             /* right hand operand for AND */
               : "cc"                           /* status flags clobbered (changed) by this operation */
    );

    return z;
}

// TODO: create a procedure that accepts a value to be shifted, an amount to shift the value by, and a mask
// TODO: shift the value as indicated first, then mask the value, then return the shifted and masked value
int shiftValues (int w, int x, int y){
        int a;
        int z;
        // TODO: create a procedure that accepts a value to be shifted, an amount to shift the value
        // by, and a mask
        asm("ASR        %[result], %[value],  %[amountShift] "
                                :[result]"=r"           (a)
                                :[value]"r"             (w),
                                 [amountShift]"r"       (x)
                                :"cc"
        );
        // TODO: shift the value as indicated first, then mask the value, then return the shifted and
        // masked value
        asm("AND        %[result], %[nv], %[mask]"
                                :[result]"=r"   (z)
                                :[nv]"r"        (a),
                                 [mask]"r"      (y)
                                :"cc"
        );
        return z;

}
