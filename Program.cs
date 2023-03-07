using OpenAI_API.Completions;
using OpenAI_API.Models;



Console.Write("Welcome!\nI need the security key that my creator sent you.\n\nEnter Here: ");

var key = Console.ReadLine();

var api = new OpenAI_API.OpenAIAPI(key);



while (true)
{
    Console.Clear();
    Console.WriteLine("****************************************************************");
    Console.WriteLine("*                         SNAKE GPT                            *");
    Console.WriteLine("****************************************************************");
    Console.WriteLine();
    Console.WriteLine("Choose an option from the menu: ");
    Console.WriteLine("\n1 - Ask a Question");
    Console.WriteLine("2 - Generate Image\n");

    Console.Write("Choose the desired option: ");
    var option = Console.ReadLine();

    if(option == "1")
    {
        Console.Clear();
        Console.WriteLine("****************************************************************");
        Console.WriteLine("*                         SNAKE GPT                            *");
        Console.WriteLine("****************************************************************");
        Console.WriteLine();
        Console.WriteLine("Choose model type: \n");
        Console.WriteLine("1 - Faster");
        Console.WriteLine("2 - Balanced");
        Console.WriteLine("3 - More Powerful\n");

        Console.Write("Choose the desired option: ");
        option = Console.ReadLine();

        if(option == "1") 
        {
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*                         SNAKE GPT                            *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            Console.WriteLine("Choose model style::");
            Console.WriteLine("\n1 - More creative");
            Console.WriteLine("2 - Balanced");
            Console.WriteLine("3 - More Accurate");

            Console.Write("\nChoose the desired option: ");
            option = Console.ReadLine();

            if( option == "1")
            {   Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.Clear();
                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.BabbageText, 1000, 0.4));
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if(option == "2")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.Clear();
                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.BabbageText, 1000, 0.6));
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if(option == "3")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.Clear();
                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.BabbageText, 1000, 0.8));
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
        else if (option == "2") 
        {
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*                         SNAKE GPT                            *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            Console.WriteLine("Choose model style::");
            Console.WriteLine("\n1 - More creative");
            Console.WriteLine("2 - Balanced");
            Console.WriteLine("3 - 3 - More Accurate");

            Console.Write("\nChoose the desired option: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.CurieText, 1000, 0.4));
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if (option == "2")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.CurieText, 1000, 0.6));
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if (option == "3")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.CurieText, 1000, 0.8));
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    
    if(option == "3")
        {
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*                         SNAKE GPT                            *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            Console.WriteLine("Choose model style::");
            Console.WriteLine("\n1 - More creative");
            Console.WriteLine("2 - Balanced");
            Console.WriteLine("3 - 3 - More Accurate");

            Console.Write("\nChoose the desired option: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.DavinciText, 1000, 0.4));
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if (option == "2")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.DavinciText, 1000, 0.6));
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if (option == "3")
            {
                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                         SNAKE GPT                            *");
                Console.WriteLine("****************************************************************");
                Console.Clear();
                Console.Write("Write your question here: ");
                string request = Console.ReadLine();

                Console.WriteLine(request);
                Console.WriteLine("\n");

                var result = await api.Completions.CreateCompletionAsync(new CompletionRequest(request, model: Model.DavinciText, 1000, 0.8));
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }  
    
    }
    if(option == "2")
    {
        Console.Clear();
        Console.WriteLine("Unavalaible!!!");
        Console.ReadKey();
    }






}