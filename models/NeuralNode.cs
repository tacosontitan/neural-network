namespace NeuralNetwork;
public class NeuralNode {
    public double Value { get; set; }
    public List<NeuralNode> ConnectedNodes { get; private set; } = new List<NeuralNode>();
    public NeuralNode(double value) => Value = value;
}