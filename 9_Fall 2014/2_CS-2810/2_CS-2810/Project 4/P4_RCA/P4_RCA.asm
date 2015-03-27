;-------1---------2---------3---------4---------5---------6---------7---------
;
; Program: Calculator.asm
; Project#: 4
; Name: Russell Andlauer
; Class: CS-2810-002
; Date: 15 Dec 2014
; Version: 1.0
;
; Ethics: I declare that the following source code was written
; solely by me. I understand that copying any source
; code, in whole or in part, constitutes cheating,
; and that I will receive a zero grade on this
; project if I am found in violation of this ethic.
;
; X _Russell Andlauer____________________________________
;
; Description: 
; A calculator that can add, multiply, negate, and clear two numbers
; Answers are only valid from 0-9
; 
; 
;-------1---------2---------3---------4---------5---------6---------7---------
.ORIG x3000 ;start of program
; Class Header
LEA R0, classHeader ;point to class string
trap x22 ;print string out
LD R0, newLine ;get carriage return
OUT ;print it out
;
; Start of main program
;
; Ask the user to input 1st number between 0-9 (echo)
;
LEA R0, promptNum
PUTS
GETC
OUT
;
; Convert the entered number from ASCII to binary and move it into R1
;
JSR ASCIItoBinary
AND R1, R1, #0
ADD R1, R0, R1
;
; Ask the user to input the 2nd number between 0-9 (echo)
LEA R0, promptNum
PUTS
GETC
OUT
; Convert the entered number from ASCII to binary and move it into R2
;
JSR ASCIItoBinary
AND R2, R2, #0
ADD R2, R0, R2
;
; Ask the user to input the operation to be performed (echo) (Exit, +, *, NOT, AND)
;
LEA R0, promptOperator
PUTS
LEA R0, opKey
PUTS
LEA R0, promptExit
PUTS
GETC
OUT
; Perform the operation and save the resulting number in R3 (echo)
;
LD R4, NegPlus
ADD R4, R4, R0
BRz GoOpAdd
;
LD R4, NegMulti
ADD R4, R4, R0
BRz GoOpMulti
;
LD R4, NegN
ADD R4, R4, R0
BRz GoOpNegate
;
LD R4, NegC
ADD R4, R4, R0
BRz GoOpClear
;
BRnp Exit
;
GoOpAdd JSR OpAdd
OUT
BRnzp Exit
;
GoOpMulti JSR OpMulti
OUT
BRnzp Exit
;
GoOpNegate JSR OpNegate
LD R4, ASCIINegSign
AND R5, R5, #0
ADD R5, R5, R0
AND R0, R0, #0
ADD R0, R0, R4
OUT
AND R0, R0, #0
ADD R0, R5, R0
OUT
BRnzp Exit
;
GoOpClear JSR OpClear
BRnzp Exit
;
Exit AND R0, R0, #0
;
LEA R0, termination ;point to termination string
PUTS
trap x25 ;stop the program
;
;=====================================================
;Subroutines
; 
ASCIItoBinary AND R4, R4, #0
LD R4, NegASCIIOffset
ADD R0, R0, R4
RET
;
OpAdd AND R3, R3, #0
ADD R3, R1, R2
LD R4, PosASCIIOffset
ADD R0, R3, R4
RET
;
OpMulti AND R3, R3, #0
AND R5, R5, #0
ADD R5, R1, R5
;
MultiLoop;
ADD R3, R3, R2
ADD R5, R5, #-1
BRp MultiLoop
;
LD R4, PosASCIIOffset
AND R0, R0, #0
ADD R0, R4, R3
RET
;
OpNegate AND R3, R3, #0
ADD R3, R2, R3
ADD R5, R2, R2;
NOT R3, R3
ADD R3, R3, #1
LD R4, PosASCIIOffset
AND R0, R0, #0
ADD R0, R3, R4
ADD R0, R0, R5
RET

OpClear AND R0, R0, #0
AND R1, R1, #0
AND R2, R2, #0
AND R3, R3, #0
AND R4, R4, #0
AND R5, R5, #0
AND R6, R7, #0
RET
;-------1---------2---------3---------4---------5---------6---------7---------
;
; Static Memory Allocation
;
;-------1---------2---------3---------4---------5---------6---------7---------
answer .BLKW x1 ;save for answer
;linkedstack .BLKW 92 ;stack store
;stack .FILL x4000 ;start of stack
;constants
classHeader .STRINGZ "CS 2810-002\nRussell Andlauer\nProject #4\n\n"
newLine .FILL x0A ;newLine character
promptNum .STRINGZ "\nEnter a number 0-9\n"
promptOperator .STRINGZ "\n\nChoose operation: +,*,n, or c\n"
opKey .STRINGZ "\n+ = add, * = multiply, n = negate, c = clear\n"
promptExit .STRINGZ "\nEnter any other key to Exit\n"
NegASCIIOffset .FILL xFFD0
PosASCIIOffset .FILL x0030
ASCIINegSign .FILL x002D
NegPlus .FILL xFFD5
NegMulti .FILL xFFD6
NegN .FILL xFF92
NegC .FILL xFF9D
termination .STRINGZ "\nProgram execution terminated!\n"
.END ;end assembly directive