 /*

     convert Celsius to Fahrenheit
     or
     convert Fahrenheit to Celsius
     based on the user choice
*/

     #include <stdio.h>

     #define FREEZING_PT 32.0f
     #define SCALE_FACTOR (5.0f/9.0f)

     int main(void)
     {
       float fahrenheit;
       float celsius;
       int convertTemp;

       printf("Enter 0 to calculate Celsius or 1 to calculate Fahrenheit: ");
       scanf("%d", &convertTemp);

       if (convertTemp == 0 )
       {
        // compute Celsius
        printf("Enter Fahrenheit Temperature: ");
        scanf("%f", &fahrenheit);
        celsius = (fahrenheit - FREEZING_PT) * SCALE_FACTOR;
		fahrenheit = (celsius) * (1/ SCALE_FACTOR ) + FREEZING_PT;

        printf("Fahrenheit = %f  and Celsius = %f\n",fahrenheit, celsius);
       }
       else
       {// compute Fahrenheit

		 printf("Enter Celsius Temperature: ");
        scanf("%f", &celsius);
		fahrenheit = (celsius) * (1/ SCALE_FACTOR ) + FREEZING_PT;

        printf("Fahrenheit = %f  and Celsius = %f\n",fahrenheit, celsius);
       }

       return(0);
     } // end main
