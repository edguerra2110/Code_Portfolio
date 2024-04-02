/**********************************************************************************
 * Program Name: lab9.c
 * Programmer: Edgar Guerra
 * Class: CSCI 2160-001
 * Lab: Lab 9 - C + GAS
 * Date: <date of completion>
 * Purpose: Demonstrates how to call ARM assembly subroutines from C driver.
 *********************************************************************************/

#include <stdio.h>
#include "logic.h"

// this is where you declare
extern void double96BitNumber(unsigned *addend, unsigned *sum);
extern long subWithCarry(long long x, long long y);
extern unsigned long long unsignedMultiply(unsigned long x, unsigned long y);
extern unsigned unsignedDivide(unsigned x, unsigned y);
extern unsigned unsignedModulo(unsigned x, unsigned y);
extern unsigned conditionalAddSub(unsigned x, unsigned y);

int main() {
        // add with carry - double a number via ADC
        unsigned arbitrary[] = {0x12345678, 0xFFFFFFFF, 0xABCDEF01};    //arbitrary[0] is most significant 32 bits
        unsigned arb_result[] = {0, 0, 0, 0};

        unsigned *ptr_arbitrary = &arbitrary[0];
        unsigned *ptr_arb_result = &arb_result[0];

        double96BitNumber(ptr_arbitrary, ptr_arb_result);

        printf("Result of arbitrary number doubling: %x %8x %8x %8x\n\n", arb_result[3], arb_result[2], arb_result[1], arb_result[0]);

        // subtract with borrow
        long long a = 0x1111111111111111, b = 0x1111111111111112;
        long long result = subWithCarry(a, b);

        printf("Result of arbitrary subtraction: %llx\n\n", result);

        // unsigned multiplication
        unsigned c = 0xffffffff, d = 0xffffffff;
        unsigned long long product = unsignedMultiply(c, d);

        printf("Result of multiplication: %llx\n\n", (unsigned long long)product);

        // unsigned division and modulo
        unsigned e = 22, f = 5;
        printf("Dividend = %d, divisor = %d; Result of division: %d; Result of modulo: %d\n\n", e, f, unsignedDivide(e, f), unsignedModulo(e, f));

        // AND

        // https://stackoverflow.com/questions/111928/is-there-a-printf-converter-to-print-in-binary-format
        #define BYTE_TO_BINARY_PATTERN "%c%c%c%c%c%c%c%c"
        #define BYTE_TO_BINARY(byte)  \
          (byte & 0x80 ? '1' : '0'), \
          (byte & 0x40 ? '1' : '0'), \
          (byte & 0x20 ? '1' : '0'), \
          (byte & 0x10 ? '1' : '0'), \
          (byte & 0x08 ? '1' : '0'), \
          (byte & 0x04 ? '1' : '0'), \
          (byte & 0x02 ? '1' : '0'), \
          (byte & 0x01 ? '1' : '0')

        printf(BYTE_TO_BINARY_PATTERN" & "BYTE_TO_BINARY_PATTERN \
                 " = "BYTE_TO_BINARY_PATTERN"\n\n", BYTE_TO_BINARY(e), \
                 BYTE_TO_BINARY(f), BYTE_TO_BINARY(inlineAND(e, f)));

        // TODO: add demonstration call to your ARM assembly conditional addition/subtraction function
        printf("First Number = %d, Second Number = %d; Result of conditionalAddSub: %d\n\n",f,e,conditionalAddSub(f,e));
        // TODO: add demonstration call to your inlined shift and mask operation
        printf("First Number = %i, Second Number = %i; Result of conditionalAddSub: %d\n\n", 2, 4, conditionalAddSub(2,4));
		printf("value: %i", shiftValue(4,1,0));
        return 0;
}
