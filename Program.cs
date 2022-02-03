using NeuralNetworkTest;
var randomGenerator = new Random();
for (int i = 0; i < 10; i++) {
    var node = new NeuralNode(randomGenerator.NextDouble());
    Console.WriteLine(node.Value);
}