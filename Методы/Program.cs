//Вид 1 ничего не принимает ничего не возвращает
void Methood1()
{
    Console.WriteLine("Автор....");
}
Methood1(); // вызов метода


//Вид 2 что-то принимает, ничего не возвращает
void Methood2( string msg)
{
 Console.WriteLine(msg);
}
Methood2(msg:"Текст сообщения") //Вызов метода

void Methood21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Methood21( msg:"Текст", count: 4) ;//вызов метода , и сколько раз мы хотим увидеть сообщение ( 4 раза написал )


//Вид 3 что то воз вращают ничего не принимают 
int Methood3() ///Обязательно указать тип данных int
{
    return DateTime.Now.Year;
}
int year =  Methood3(); //вызов метода
Console.WriteLine(year);



//Вид 4 методы которые,что-то принимают и что-то возвращают  
 string Methood4 (int count, string text)
{
    int i = 0;
    string result = String.Emty;

    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Methood(10, "asdf"); //вывзов метода
Console.WriteLine(res); 

/// c циктом For
string Methood4 (int count, string text)
{
    int i = 0;
    string result = String.Emty;
    for(  int i = 0; i < count; i++)
    {
        result = result + text; 
    }
    return result;
}

string res = Methood(10, "asdf"); //вывзов метода
Console.WriteLine(res); 







