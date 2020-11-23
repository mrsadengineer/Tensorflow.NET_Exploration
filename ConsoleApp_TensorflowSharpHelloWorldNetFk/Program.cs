using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Tensorflow;
using static Tensorflow.Binding;

namespace ConsoleApp_TensorflowSharpHelloWorldNetFk
{
    class Program
    {
   
      //  public ExampleConfig Config { get; set; }
        static void Main(string[] args)
        {


            //LearnExamples.CreateTensors();
            //  LearnExamples.CreateConstants();

            // LearnExamples.CreateVariable();
            //  bool didRun = Run();


            Console.WriteLine($"TensorFlow Binary v{tf.VERSION}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"TensorFlow.NET v{Assembly.GetAssembly(typeof(TF_DataType)).GetName().Version}");
            Console.WriteLine("System/App Info");
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine($"64Bit Operating System: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($".NET CLR: {Environment.Version}");
            Console.WriteLine(Environment.CurrentDirectory);
            Console.ResetColor();



            //LearnExamples.CreateVariable();

            LearnExamples.CreateSession();






            Console.WriteLine("End Here");
   

        }


        public void runHelloWorld()
        {
   var hello = tf.constant("Hello, TensorFlow!");
            Console.WriteLine(hello);
            Console.WriteLine("test here");
            Console.ReadKey();

        }

        public static bool Run()
        {
            /* Create a Constant op
               The op is added as a node to the default graph.
            
               The value returned by the constructor represents the output
               of the Constant op. */
            var str = "Hello, TensorFlow.NET!";
            var hello = tf.constant(str);

            // tf.Tensor: shape=(), dtype=string, numpy=b'Hello, TensorFlow.NET!'
            print(hello);

            var tensor = (string)hello.numpy();

            return str == tensor;
        }
    }
}

      //  public ExampleConfig InitConfig()
      //  => Config = new ExampleConfig
      //  {
     //       Name = "Hello World",
     //       Priority = 1
       // };
////config 

//public int Priority { get; set; } = 100;

///// <summary>
///// Example name
///// </summary>
//public string Name { get; set; }

///// <summary>
///// True to run example
///// </summary>
//public bool Enabled { get; set; } = true;

///// <summary>
///// Set true to import the computation graph instead of building it.
///// </summary>
//public bool IsImportingGraph { get; set; } = false;
