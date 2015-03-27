// File Prologue
// Implementation File for the myRectangle class
// Class: CS-1410
// Project: Lab 03
// Author: Russell Andlauer
// Date Last Modified: September 10th, 2014
// ------------------------------------------------------------------------
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
// ------------------------------------------------------------------------

#include "myRectangle.h"
#pragma once

myRectangle::myRectangle()
{
	height = 0;
	width = 0;
}

myRectangle::myRectangle(const int newHeight, const int newWidth)
{
	height = newHeight;
	width = newWidth;
}

int myRectangle::getHeight() const
{
	return height;
}

void myRectangle::setHeight(const int newHeight)
{
	height = newHeight;
}

int myRectangle::getWidth() const
{
	return width;
}

void myRectangle::setWidth(const int newWidth)
{
	width = newWidth;
}

int myRectangle::calcArea() const
{
	return height * width;
}

