using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static Tensorflow.Binding;

namespace ConsoleApp_TensorflowSharpHelloWorldNetFk
{
    class Program
    {
        public int Priority { get; set; } = 100;

        /// <summary>
        /// Example name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// True to run example
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Set true to import the computation graph instead of building it.
        /// </summary>
        public bool IsImportingGraph { get; set; } = false;


      //  public ExampleConfig Config { get; set; }


        static void Main(string[] args)
        {
            var hello = tf.constant("Hello, TensorFlow!");
            Console.WriteLine(hello);
            Console.WriteLine("test here");
            Console.ReadKey();


            //bool didRun = Run();
            // Console.WriteLine("write here");
            // Console.ReadKey();

        }


      //  public ExampleConfig InitConfig()
      //  => Config = new ExampleConfig
      //  {
     //       Name = "Hello World",
     //       Priority = 1
       // };

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
