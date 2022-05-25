Console.WriteLine("How many centuries would you like to enter:");
string num0 = Console.ReadLine();
int num = int.Parse(num0);
long num1 = long.Parse(num0);
num1 = num1*3155673600;
Console.WriteLine(num0);
Console.WriteLine(  num+" centuries" + " = "+ 
                     num*100 +" years" + " = "+
                     num*36524 + " days" + " = "+
                     num*876576 + " hours" + " = "+
                     num*52594560 + " minutes"+ " = "+
                     num1 + " seconds" + " = "+
                     num1*1000 + " milliseconds" + " = "+
                     num1*1000000 + " microseconds" + " = "+
                    num1*1000000000 + " nanoseconds");