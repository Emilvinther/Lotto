int [] winner = new int [7];
int [] player = new int [7];
Random random = new Random ();
int winnernumbers = 0;

for (int i = 0; i < winner.Length; i++)
{
    winner [i] = random.Next (1, 20);
}

for (int i = 0; i < player.Length; i++)
{
    Console.WriteLine("Vælg et nummer");
    player[i] = Convert.ToInt32(Console.ReadLine());
}

//for (int i = 0; i < player.Length; i++)
//{

//    Console.Write(player[i] + " ");
//}

for (int i = 0; i < player.Length; i++)
{
    for (int j = 0; j < winner.Length; j++)
    {
        if (player[i] == winner[j])
        {
            winnernumbers++;
        }
    }

}

Console.WriteLine ("Du har {0} rigtige", winnernumbers);


Console.ReadKey ();

