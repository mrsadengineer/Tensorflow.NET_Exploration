using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Tensorflow;
using NumSharp;
using static Tensorflow.Binding;

using Tensorflow.Graphs;
namespace ConsoleApp_TensorflowSharpHelloWorldNetFk
{
    class LearnExamples
    {
        //chapter 17: convolution neural network
        //chapter 16: neural network
        //chapter 15: image recognition
        //chapter 14: nearest neighbor
        //chapter 13: Logisitic Regression
        //chapter 12: Linear regression
        //chapter 11: eager mode
        //chapter 10: trainer

        //chapter 9: Gradient
        //chapter 8: Queue

        //chapter 7: Operations
        
        //chapter 6 - session
        public static void CreateSession()
        {
            //tf_with<Graph>(tf.Graph().as_default(), graph =>
            //{
            //    var variable = tf.Variable(31, name: "tree");
            //    tf.global_variables_initializer();
            //    variable.assign(12);
            //});


            //tf_with<Graph>(tf.Graph().as_default(), graph =>
            //{
            //    var variable = tf.Variable(31, name: "tree");
            //    var init = tf.global_variables_initializer();

            //    var sess = tf.Session(graph);
            //    sess.run(init);

            //    var result = sess.run(variable); // 31

            //    var assign = variable.assign(12);
            //    result = sess.run(assign); // 12
            //});

            // Initialize the variables (i.e. assign their default value)
            var init = tf.global_variables_initializer();
          
            // var sess = tf.Session();

            var a = 2;
            var b = 3;

            var c = tf.add(a, b,"add");
            // print(sess.run(c));
            //var graph = tf.Graph().as_default();
            using (var sess = tf.Session())
            {
                //sess.run(init);

                //print(c.op);

                print(tf.add(2, 5));


                //   sess.__init__();
             // sess.run(c.op);
                
                //print(sess.run(c));
            }

            //sess.close();

        }
        

        //Chapter 5: Graphs


        //chapter 4: Create Placeholders


        //chapter 3: - Variables

        public static void CreateVariable()
        {
            var x = tf.Variable(10, name: "x");


            using (var session = tf.Session())
            {

                
              session.run(x.initializer);
             //   var result = session.run(x);
             //   Console.Write(result.ToString()); // should be 10
            }


        }








     //
     //chapter 2: Constants
        //Initialize a scalar constant:
        public static void CreateConstants()
        {

            var c1 = tf.constant(3); // int
            var c2 = tf.constant(1.0f); // float
            var c3 = tf.constant(2.0); // double
            var c4 = tf.constant("Big Tree"); // string


            Console.WriteLine($"\n\n" +
                $"c1: {c1}\n\n" +
                $"c2 : {c2}\n\n"  +
                $"c3 : {c3}\n\n"  +
                $"c4 : {c4}\n\n" );




            // dtype=int, shape=(2, 3)
            var nd = np.array(new int[,]
            {
        {1, 2, 3},
        {4, 5, 6}
            });
            var tensor = tf.constant(nd);

            Console.WriteLine($"\nnd: \n {nd}");


            Console.WriteLine($"\n\n nd: {tensor}");


 //other constant 
        //tf.zeros
        //tf.zeros_like
        //tf.ones
        //tf.ones_like
        //tf.fill
          //  Console.WriteLine($"\n\n" +
             //   $"{tf.zeros}");
        }






        public static void CreateTensors() {

            // Create a tensor holds a scalar value
            var t1 = new Tensor(3);

            // Init from a string
            var t2 = new Tensor("Hello! TensorFlow.NET");

            // Tensor holds a ndarray
            var nd = new NDArray(new int[] { 3, 1, 1, 2 });
            var t3 = new Tensor(nd);

            Console.WriteLine($"t1: {t1} ,\n t2: {t2},\n  t3: {t3}");
        }


   
       

    }
}
