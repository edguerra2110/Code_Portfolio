/**********************************************************************************
 * Program Name: logic.h
 * Programmer: <your name here>
 * Class: CSCI 2160-001
 * Lab: Lab 9 - C + GAS
 * Date: <date of completion>
 * Purpose: Declaration (sort of like an interface) of external procedures 
 *	        and functions for logic.c
 *********************************************************************************/

// these are known as "include guards"--they "guard" against including something more than once
#ifndef LOGIC_H
#define LOGIC_H

int inlineAND(int x, int y);


// TODO: add a declaration for your shift-and-mask function
int shiftValues(int w, int x, int y);
#endif // LOGIC_H
