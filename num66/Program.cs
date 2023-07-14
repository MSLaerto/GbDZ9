int GetInt(string message){
    Console.Write("Введите {0}: " , message);
    int a = Convert.ToInt32(Console.ReadLine());
    while( a < 1 ){
        Console.WriteLine("Элемент должен быть натуральным числом: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;
}
int Recursion(int m , int n , int result){
    if (m < n){
        result = result + m ;
        return Recursion(m + 1 , n , result);
    }else if ( m > n){
        result = result + m ;
        return Recursion(m - 1 , n , result);
    }else{
        return result + m;
    }

} 
Console.WriteLine("Полученная сумма :{0}", Recursion(GetInt("M") , GetInt("N") , 0));