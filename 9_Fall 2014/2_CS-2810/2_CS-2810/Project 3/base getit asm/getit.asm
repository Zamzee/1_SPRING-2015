;-------1---------2---------3---------4---------5---------6---------7---------
;
; Program: getit.asm
; Project#: 2
; Name: Russell Andlauer
; Class: CS-2810-002
; Date: 18 Nov 2014
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
; Description: Print out template then
; get a number 0-9 from the keyboard and print it out.
; Print error message if incorrect input
; Check to see if number matches secret number (5)
; Repeat until a 5 is entered
;-------1---------2---------3---------4---------5---------6---------7---------
.ORIG x3000 ;start of program
lea r0, classHeader ;point to class string
trap x22 ;print string out
ld r0, newLine ;get carriage return
OUT ;print it out
IN;
OUT;
ld r0, newLine;
lea r0, charReceived;
PUTS
lea r0, termination ;point to termination string
PUTS
trap x25 ;stop the program
;-------1---------2---------3---------4---------5---------6---------7---------
;
; Static Memory Allocation
;
;-------1---------2---------3---------4---------5---------6---------7---------
answer .BLKW x1 ;save for answer
.BLKW x10 ;stack store
stack .FILL xFFFF ;start of stack
;constants
classHeader .STRINGZ "CS 2810-002\nRussell Andlauer\nProject #3\n\n"
newLine .FILL x0A ;newLine character
charReceived .STRINGZ "\nCharacter Received...\n"
termination .STRINGZ "Thank You \nProgram execution terminated!\n"
.END ;end assembly directive