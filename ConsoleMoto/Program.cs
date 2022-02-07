// See https://aka.ms/new-console-template for more information
using ConsoleMoto;


Moto moto = new Moto();
Console.WriteLine("Hello, World!");
moto.DefinirNomeMoto(" KAWASAKY ");
moto.LigarMoto();
Iniciar(moto);

static void Iniciar(Moto moto) 
{
    Console.Clear();

    if (moto.Ligado) 
    {
        Console.WriteLine("\t ********************");
        Console.WriteLine("\t Moto ligada ");
        Console.WriteLine("\t ********************");
        Console.WriteLine("\t Nome: "+moto.RetornaNomeMoto());
        Console.WriteLine("\t Velocidade: " + moto.RetornaVelocidadeMoto());

    }
    else 
    {
        moto.Velocidade = 0;
        Console.WriteLine("\t ********************");
        Console.WriteLine("\t Moto Desligada ");
        Console.WriteLine("\t ********************");
        Console.WriteLine("\t Nome: " + moto.RetornaNomeMoto());
        Console.WriteLine("\t Velocidade: " + moto.RetornaVelocidadeMoto());

    }
    Console.WriteLine("\t------------------");
    Console.WriteLine("\t O que deseja Fazer? ");
    Console.WriteLine("\t Acelerar a MOto? Digite 1 ");
    Console.WriteLine("\t Freiar a MOto? Digite 2 ");
   
    if(!moto.Ligado)
        Console.WriteLine("\t Ligar a MOto? Digite 3 ");
    else
        Console.WriteLine("\t Desl igar a MOto? Digite 3 ");
        Console.WriteLine("\t  Digite 4 Para Sair ");
    string escolha=Console.ReadLine();
    var escolhaint = Convert.ToInt32(escolha);

    if((escolhaint==1||escolhaint==2)&& !moto.Ligado)
    {
        Console.WriteLine("\t Você deve Ligar a Moto Primeiro");
        Thread.Sleep(3000);
        Iniciar(moto);
    }

    switch(escolhaint)
    {
        case 1:
            moto.AcelerarMoto();
        Iniciar(moto);
            break;

        case 2:
            moto.FreiarMoto();
        Iniciar(moto);

            break;

        case 3:
            if (moto.Ligado)
            {
                moto.DesligarMoto(); 
            }
            else
            {
                moto.LigarMoto();
            }
            
        Iniciar(moto);
            break;

        case 4:

            Console.WriteLine("\t APERTE QUALQUER TECLA PARA FINALIZAR");

            break;


        default:
            Iniciar(moto);
            break;


    }

   






}
