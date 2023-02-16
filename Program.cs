// calculates the sum of all the numbers from n to m recursively
namespace Program;

class sumofnumbersTask{

public static int sumofnumbers (int n , int m){

int sum = n;

if (n < m){
    n++;
    sum += sumofnumbers(n,m) ;
    Console.WriteLine(sum);
}
return sum;
}

public static void Main (string [] args){
Console.WriteLine (sumofnumbers(1,3));

}


}