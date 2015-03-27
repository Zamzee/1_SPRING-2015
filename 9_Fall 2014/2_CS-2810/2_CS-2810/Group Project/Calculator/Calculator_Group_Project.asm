;-------1---------2---------3---------4---------5---------6---------7---------
;
; Program: Calculator_Group_Project.asm
; Project#: Calculator Group Project
; Name: Russell Andlauer, Michael De La Barra, Ernie Vilela
; Class: CS-2810-002
; Date: 10 Dec 2014
; Version: 1.0
;
; Ethics: I declare that the following source code was written
; solely by me. I understand that copying any source
; code, in whole or in part, constitutes cheating,
; and that I will receive a zero grade on this
; project if I am found in violation of this ethic.
;
; X Russell Andlauer, Michael De La Barra, Ernie Vilela
;
; Description: 
; A calculator that can add, subtract, multiply, and clear two numbers or negate a number
; 
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
; Ask the user to input the operation to be performed (echo) (Exit, +, -, *, NOT, AND)
;
LEA R0, promptOperator
PUTS
LEA R0, opKey
PUTS
LEA R0, promptAnswer
PUTS
LEA R0, promptExit
PUTS
GETC
OUT
; Perform the operation and save the resulting number in R3 (echo)
;
LD R4, Plus
ADD R4, R4, R0
BRz GoOpAdd
;
LD R4, Minus
ADD R4, R4, R0
BRz GoOpSubtract
;
LD R4, Multi
ADD R4, R4, R0
BRz GoOpMulti
;
LD R4, N
ADD R4, R4, R0
BRz GoOpNegate
;
LD R4, C
ADD R4, R4, R0
BRz GoOpClear
;
BRnp Exit
;
GoOpAdd JSR OpAdd
OUT
BRnzp Exit
;
GoOpSubtract JSR OpSubtract
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
OpSubtract AND R3, R3, #0
NOT R2, R2
ADD R2, R2, #1
LD R4, PosASCIIOffset
AND R0, R0, #0
ADD R3, R1, R2
ADD R0, R3, R4
;ADD R0, R0, R5
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
;
OpNegate AND R3, R3, #0
ADD R3, R2, R3
ADD R5, R2, R2; Save double input value in R5 for later ASCII conversion
NOT R3, R3
ADD R3, R3, #1
LD R4, PosASCIIOffset
AND R0, R0, #0
ADD R0, R3, R4
ADD R0, R0, R5
RET
;
OpClear AND R0, R0, #0
AND R1, R1, #0
AND R2, R2, #0
AND R3, R3, #0
AND R4, R4, #0
AND R5, R5, #0
RET
;//////////////////////////////////////////////////////////////
;
;-------1---------2---------3---------4---------5---------6---------7---------
;
; Static Memory Allocation
;
;-------1---------2---------3---------4---------5---------6---------7---------
answer .BLKW x1 ;save for answer
;constants
classHeader .STRINGZ "CS 2810\nCalculator Project\n\n"
newLine .FILL x0A ;newLine character
promptNum .STRINGZ "\nEnter a number 0-9\n"
promptAnswer .STRINGZ "\nAnswer range valid from 0-9"
promptOperator .STRINGZ "\nChoose operation: +, -, *, n, or c\n"
opKey .STRINGZ "\nn = negate, c = clear\n"
promptExit .STRINGZ "\nEnter any key to Exit\n"
NegASCIIOffset .FILL xFFD0
PosASCIIOffset .FILL x0030
ASCIINegSign .FILL x002D
Plus .FILL xFFD5
Minus .FILL xFFD3
Multi .FILL xFFD6
N .FILL xFF92
C .FILL xFF9D
termination .STRINGZ "\nExiting"
; ////////////////////////////////////////
; Attempted to create a lookup table to use for displaying double digit answers
;LookUp10 .FILL #0
;.FILL #10
;.FILL #20
;.FILL #30
;.FILL #40
;.FILL #50
;.FILL #60
;.FILL #70
;.FILL #80
;
;Neg10 .FILL xFFF6
.END ;end assembly directive