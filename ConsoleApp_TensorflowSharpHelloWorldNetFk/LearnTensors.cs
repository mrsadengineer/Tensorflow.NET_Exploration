using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Tensorflow;
using NumSharp;
using static Tensorflow.Binding;
namespace ConsoleApp_TensorflowSharpHelloWorldNetFk
{
    class LearnExamples
    {


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


        //


        public static void CreateConstants()
        {

            var c1 = tf.constant(3); // int
            var c2 = tf.constant(1.0f); // float
            var c3 = tf.constant(2.0); // double
            var c4 = tf.constant("Big Tree"); // string




            // dtype=int, shape=(2, 3)
            var nd = np.array(new int[,]
            {
        {1, 2, 3},
        {4, 5, 6}
            });
            var tensor = tf.constant(nd);
        }
        //tf.zeros
        //tf.zeros_like
        //tf.ones
        //tf.ones_like
        //tf.fill

    }
}
