
        
void Countdown(int a){
    if (a == 0)
    {
        return;
    }
    Console.WriteLine(a);
    Countdown(a-1);
}
Countdown(10);  