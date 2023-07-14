int GetInt(string message){
    Console.Write("Введите {0}: " , message);
    int a = Convert.ToInt32(Console.ReadLine());
    while( a < 0 ){
        Console.WriteLine("Элемент должен быть неотрицательным числом: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;
}
int Akkerman(int m , int n){
    if (m == 0){
        return n+1;
    }else if ( m>0 && n==0 ){
        return Akkerman(m-1 , 1);
    }else{
        return Akkerman(m-1, Akkerman(m , n-1));
    }

} 
Console.WriteLine("Полученная рекурсия :{0}", Akkerman(GetInt("m") , GetInt("n")));