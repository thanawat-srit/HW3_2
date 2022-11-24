class Program
{
    static CircularLinkedList<char> l1 = new CircularLinkedList<char>();
    static void Main(string[] args)
    {
        Input();
        Cut();
        Output();
    }
    static void Input(){
        while (true)
        {
            char input = char.Parse(Console.ReadLine());
            if (input == 'L' || input == 'M' || input == 'S')
            {
                Program.l1.Add(input);
            }
            else
            {
                break;
            }
        }
    }
    static void Output(){
        for (int i = 0; i < Program.l1.GetLength(); i++){
            Console.Write("{0}",Program.l1.Get(i));
        }
    }
    static void Cut(){
        int index = 0;
        while(index<3){
            for(int i = 0;i<Program.l1.GetLength();i++){
                if(Program.l1.Get(i)=='L'){
                    Console.Write("1");
                }else if(Program.l1.Get(i)=='M'){
                    Console.Write("2");
                }else if(Program.l1.Get(i)=='S'){
                    Console.Write("3");
                }
            }
            
            for(int i = 0;i<Program.l1.GetLength();i++){
                if(Program.l1.Get(i)=='L'){
                    Program.l1.Insert(i,'M');
                    Program.l1.Insert(i,'M');
                    Program.l1.Remove(i+2);
                    i++;

                }else if(Program.l1.Get(i)=='M'){
                    
                    Program.l1.Insert(i,'S');
                    Program.l1.Insert(i,'S');
                    Program.l1.Insert(i,'S');
                    Program.l1.Remove(i+3);
                    i+=2;
                }else if(Program.l1.Get(i)=='S'){
                    Program.l1.Remove(i);
                    i--;
                }
            }
            index++;
        }
    }
}